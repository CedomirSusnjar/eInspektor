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
            this.companyTableAdapter.FillByIsActive(this.dataSources.company);
            this.controlTableAdapter.FillByIsActive(this.dataSources.control);

            db = new DatabaseModel();
            fillCompanyNamesIntoTable();
            fillInspectorNames();
            fillVehicles();
            this.hasChanges = false;   
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

    }
}
