using eInspektor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eInspektor.Views
{
    public partial class Plan : Form
    {
        public StartForm startForm { get; set; }
        private DatabaseModel db;
        private Dictionary<int, Tuple<string, string>> companyIdNamesAddress;
        private bool hasChanges;
        public Plan()
        {
            InitializeComponent();
        }


        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.FillByIsActive(this.dataSources.company/*, DateTime.Today.AddYears(-1)*/);
            dayMI.Text = "Dan - Ponedjeljak";
            db = new DatabaseModel();
            getControlsByDayInWeek(DayOfWeek.Monday);           
            // fillCompanyNamesIntoTable();
            // fillInspectorNames();
            // fillVehicles();
            hasChanges = false;   
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.hasChanges)
                {
                    DialogResult result = MessageBox.Show("Izmjene nisu sačuvane. Želite li ih sačuvati prije nego što napustite raspored?", "Raspored", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes || result == DialogResult.No)
                    {
                        if (result == DialogResult.Yes)
                        {
                            //Save changes
                            sacuvaj_ToolStripMenuItem_Click(null, e);
                        }
                        await Task.Delay(100);      //Doesn't work othervise
                        base.OnFormClosing(e);
                        this.Close();
                        startForm.Show();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    //There has been no modifications to table
                    base.OnFormClosing(e);
                    startForm.Show();
                }
            }
        }

        private void sacuvaj_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehicleGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.hasChanges = true;
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijednu kontrolu.");
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati odabrane kontrole?", "Brisanje kontrola", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int selIndex = controlsGridView.SelectedRows[0].Index;
                for (int i = 0; i < controlsGridView.SelectedRows.Count; i++)
                {
                    int id = 0;
                    try
                    {
                        id = (int)controlsGridView.SelectedRows[i].Cells["id"].Value;
                    }
                    catch (NullReferenceException)
                    {
                        //the row is already deleted
                        continue;
                    }

                    control v = db.controls.Find(id);
                    if (v != null)
                    {
                        v.isActive = 0;
                    }
                }
                db.SaveChanges();
                Plan_Load(sender, e);
                if (selIndex != 0 && selIndex < controlsGridView.Rows.Count)
                {
                    controlsGridView.Rows[selIndex - 1].Selected = true;
                }
            }
        }

        private void fillCompanyNamesIntoTable()
        {
            var query = from com in db.companies
                        select new
                        {
                            id = com.id,
                            name = com.name,
                            location = com.location
                        };

            companyIdNamesAddress = new Dictionary<int, Tuple<string, string>>();

            foreach (dynamic item in query)
            {
                companyIdNamesAddress.Add(item.id, new Tuple<string, string>((string)item.name, (string)item.location));
            }
            for (int i = 0; i < controlsGridView.Rows.Count; i++)
            {
                int compId = (int)controlsGridView.Rows[i].Cells["company_id"].Value;
                controlsGridView.Rows[i].Cells["company"].Value = companyIdNamesAddress[compId].Item1;
                controlsGridView.Rows[i].Cells["address"].Value = companyIdNamesAddress[compId].Item2;
            }
        }

        private void fillInspectorNames()
        {
            for (int i = 0; i < controlsGridView.Rows.Count; i++)
            {
                int controlId = (int)controlsGridView.Rows[i].Cells["id"].Value;

                string inspectorNames = "";
                foreach (var item in db.controls.Find(controlId).inspectors)
                {
                    if ("".Equals(inspectorNames) == false)
                    {
                        inspectorNames += ", ";
                    }
                    inspectorNames += item.first_name + " " + item.last_name;
                }
                controlsGridView.Rows[i].Cells["inspector"].Value = inspectorNames;
            }
        }

        private void fillVehicles()
        {
            for (int i = 0; i < controlsGridView.Rows.Count; i++)
            {               
                int controlId = (int)controlsGridView.Rows[i].Cells["id"].Value;
                var controlVehicleQuery = from v in db.vehicle_responsibility
                                            where v.control_id == controlId
                                            select v.vehicle_id;
                string vehicleNames = "";
                foreach (var item in controlVehicleQuery.ToList())
                {
                    if ("".Equals(vehicleNames) == false)
                    {
                        vehicleNames += ", ";
                    }
                    var veh = from v in db.vehicles where v.id == item select v;
                    vehicleNames += veh.First().name;
                }
                controlsGridView.Rows[i].Cells["vehicles_column"].Value = vehicleNames;
            }

        }

        /**<summary>
         * Opens form for adding new controls
         * </summary>
         */
        private void ručnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(companiesGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Odaberite jedan subjekt!");
                return;
            }
            NewControlsView d = new NewControlsView((int)companiesGridView.SelectedRows[0].Cells["id_subject"].Value);
            d.plan = this;
            d.setTitleLabel((string)companiesGridView.SelectedRows[0].Cells["nameColumn"].Value);
            d.Show();
            this.Hide();
        }

        private void subjekteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.companyTableAdapter.FillByDateLC(this.dataSources.company, DateTime.Today.AddYears(-1));
        }

        private void subjekteIInspektoreToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            DateTime dt = DateTime.Today.AddYears(-1);
            var queryCompany = from v in db.companies
                               where v.last_control < dt
                               select new
                               {
                                   id = v.id,
                                   name = v.name,
                                   last_control = v.last_control,
                                   location = v.location
                               };

            var queryInspectors = from v in db.inspectors
                                  select new
                                  {
                                      id = v.id,
                                      full_name = v.first_name + " " + v.last_name
                                  };

            var queryVehicles = from v in db.vehicles
                                select new
                                {
                                    id = v.id,
                                    registration_num = v.registration_num
                                };

            var limitedQuery = queryCompany.Take(queryInspectors.Count() * queryVehicles.Count());

            Dictionary<string, Tuple<Tuple<string,string>, string>> triple = new Dictionary<string, Tuple<Tuple<string,string>, string>>();

            DateTime dtt = DateTime.Now;
            while (dtt.DayOfWeek != DayOfWeek.Monday)
            {
               dtt = dtt.AddDays(1);
            }

            for (int i = 0; i < limitedQuery.Count(); i++)//kontrola u bazu
            {
                control c = new control();
                c.company_id = limitedQuery.ToList()[i].id;
                c.control_justified = 1;
                c.is_finished = 0;
                c.isActive = 1;
                int l = i%5;
                switch (l)
                {
                    case 1:
                        c.start_date = dtt;
                        break;
                    case 2:
                        c.start_date = dtt.AddDays(1);
                        break;
                    case 3:
                        c.start_date = dtt.AddDays(2);
                        break;
                    case 4:
                        c.start_date = dtt.AddDays(3);
                        break;
                    case 5:
                        c.start_date = dtt.AddDays(4);
                        break;
                    default:
                        c.start_date = dtt.AddDays(5);
                        break;
                }                            
                db.controls.Add(c);
            }
            db.SaveChanges();

            var queryControls = from v in db.controls                              
                                select new
                                {
                                    id = v.id,
                                    company_id = v.company_id
                                };
         
            for (int i = 0; i < queryCompany.Count(); i++)//vehicle_respons u bazu
            {
                vehicle_responsibility vr = new vehicle_responsibility();
                vr.vehicle_id = queryVehicles.ToList()[i % queryVehicles.Count()].id;
                vr.inspector_id = queryInspectors.ToList()[i % queryInspectors.Count()].id;
                vr.control_id = queryControls.ToList()[i].id;
                int l = i % 6;
                switch (l)
                {
                    case 1:
                        vr.date = dtt;
                        break;
                    case 2:
                        vr.date = dtt.AddDays(1);
                        break;
                    case 3:
                        vr.date = dtt.AddDays(2);
                        break;
                    case 4:
                        vr.date = dtt.AddDays(3);
                        break;
                    case 5:
                        vr.date = dtt.AddDays(4);
                        break;
                    default:
                        vr.date = dtt.AddDays(5);
                        break;
                }
                
                triple.Add(queryCompany.ToList()[i].name, new Tuple<Tuple<string,string>, string>(new Tuple<string,string>(queryCompany.ToList()[i].location, queryInspectors.ToList()[i % queryInspectors.Count()].full_name), queryVehicles.ToList()[i % queryVehicles.Count()].registration_num));
                db.vehicle_responsibility.Add(vr);             
            }
            db.SaveChanges();

            dayMI.Text = "Dan - Ponedjeljak";
            getControlsByDayInWeek(DayOfWeek.Monday);
        }

        private void ponedjeljakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dayMI.Text = "Dan - Ponedjeljak";
            getControlsByDayInWeek(DayOfWeek.Monday);
        }

        private void utorakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dayMI.Text = "Dan - Utorak";
            getControlsByDayInWeek(DayOfWeek.Tuesday);
        }

        private void srijedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dayMI.Text = "Dan - Srijeda";
            getControlsByDayInWeek(DayOfWeek.Wednesday);
        }

        private void četvrtakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dayMI.Text = "Dan - Četvrtak";
            getControlsByDayInWeek(DayOfWeek.Thursday);        
        }

        private void getControlsByDayInWeek(DayOfWeek dayOfWeek)
        {
            var query = from v in db.vehicle_responsibility
                        select new
                        {
                            inspector_id = v.inspector_id,
                            vehicle_id = v.vehicle_id,
                            control_id = v.control_id,
                            date = v.date
                        };

            Dictionary<string, Tuple<Tuple<string, string>, string>> triple = new Dictionary<string, Tuple<Tuple<string, string>, string>>();
            Dictionary<int, Tuple<Tuple<int, int>, DateTime>> controlGridViewTuple = new Dictionary<int, Tuple<Tuple<int, int>, DateTime>>();
            Dictionary<int, Tuple<int, sbyte?>> twoBooleans = new Dictionary<int, Tuple<int, sbyte?>>();
            int[] company_ids = new int[query.Count()];
                
            foreach (dynamic item in query)
            {
                if (item.date.DayOfWeek == dayOfWeek)
                    try
                    {
                        controlGridViewTuple.Add(item.control_id, new Tuple<Tuple<int, int>, DateTime>(new Tuple<int, int>(item.inspector_id, item.vehicle_id), item.date));
                    }
                    catch (Exception)
                    {
                        //It is already added
                    }
            }

            for (int i = 0; i < controlGridViewTuple.Count(); i++)
            {
                int ide = controlGridViewTuple[controlGridViewTuple.ElementAt(i).Key].Item1.Item1;
                var insp = from v in db.inspectors
                           where v.id == ide
                           select new
                           {
                               full_name = v.first_name + " " + v.last_name
                           };

                int idd = controlGridViewTuple[controlGridViewTuple.ElementAt(i).Key].Item1.Item2;
                var vehicle = from v in db.vehicles
                              where v.id == idd
                              select v.registration_num;

                int idf = controlGridViewTuple.ElementAt(i).Key;

                var control = from v in db.controls
                              where v.id == idf
                              select new
                              {
                                  company_id = v.company_id,
                                  is_finished = v.is_finished,
                                  control_justified = v.control_justified
                              };
                twoBooleans.Add(i, new Tuple<int, sbyte?>(control.ToList().First().is_finished, control.ToList().First().control_justified));

                int idg = control.ToList().First().company_id;


                var company = from v in db.companies
                              where v.id == idg
                              select new
                              {
                                  name = v.name,
                                  location = v.location
                              };

                string vehicle_reg_num = vehicle.ToList().First();
                string company_name = company.ToList().First().name;
                string location = company.ToList().First().location;
                string insp_name = insp.ToList().First().full_name;
                company_ids[i] = idg;


                try
                {
                    triple.Add(key: company_name, value: new Tuple<Tuple<string, string>, string>(new Tuple<string, string>(location, insp_name), vehicle_reg_num));
                }
                catch (Exception)
                {
                    //Already added
                }

            }
            controlsGridView.RowCount = triple.Count;
            for (int i = 0; i < triple.Count; i++)
            {
                controlsGridView.Rows[i].Cells["company"].Value = triple.ElementAt(i).Key;
                controlsGridView.Rows[i].Cells["address"].Value = triple.ElementAt(i).Value.Item1.Item1;
                controlsGridView.Rows[i].Cells["inspector"].Value = triple.ElementAt(i).Value.Item1.Item2;
                controlsGridView.Rows[i].Cells["vehicles_column"].Value = triple.ElementAt(i).Value.Item2;
                controlsGridView.Rows[i].Cells["control_justified"].Value = twoBooleans[i].Item2;
                controlsGridView.Rows[i].Cells["is_finished"].Value = twoBooleans[i].Item1;
                controlsGridView.Rows[i].Cells["company_id"].Value = company_ids[i];
            }
        }

        private void petakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dayMI.Text = "Dan - Petak";
            getControlsByDayInWeek(DayOfWeek.Friday);
        }

        private void subotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dayMI.Text = "Dan - Subota";
            getControlsByDayInWeek(DayOfWeek.Saturday);
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void izvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Checks for selecting a single row
            if(controlsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Odaberite jednu kontrolu.");
                return;
            }

            var reportsView = new ReportView();
            reportsView.controlId = (int)controlsGridView.SelectedRows[0].Cells["company_id"].Value;
            reportsView.lbcompanyName.Text = (string)controlsGridView.SelectedRows[0].Cells["company"].Value;
            reportsView.ShowDialog();
            Plan_Load(sender, e);
        }
    }
}
