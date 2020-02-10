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
    public partial class NewControlsView : Form
    {
        public Plan plan;
        private int companyId;
        private List<vehicle> selectedVehicles;
        private List<inspector> selectedInspectors;
        private List<string> inspectorNames;
        private Dictionary<string, int> inspectorNamesId;
        private bool noVehicles = false;
        public NewControlsView(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        private void NewControlsView_Load(object sender, EventArgs e)
        {
             this.vehicleTableAdapter.FillByIsActive(this.dataSources.vehicle);
             this.inspectorTableAdapter.FillByActiveAndAvailable(this.dataSources.inspector);
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Želite li odustati od dodavanja?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await Task.Delay(100);      //Doesn't work othervise
                    base.OnFormClosing(e);
                    this.Close();
                    plan.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void potvrdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inspectorsGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Odaberite barem jednog inspektora!");
                return;
            }
            if (vehiclesGridView.SelectedRows.Count < 1)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da ne želite dodati vozilo?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    noVehicles = false;
                    return;
                }
                else
                {
                    noVehicles = true;
                }
            }
            else
            {
                noVehicles = false;
            }
            //Check if user refreshed responsibilities table
            if (vehiclesGridView.SelectedRows.Count != responsibilitiesGridView.Rows.Count)
            {
                MessageBox.Show("Osvježite tabelu!");
                return;
            }

            if (noVehicles == false)
            {
                //check if all vehicles have responsible inspector
                for (int i = 0; i < responsibilitiesGridView.RowCount; i++)
                {
                    if ((int?)responsibilitiesGridView.Rows[i].Cells["inspector_id_column"].Value == null)
                    {
                        //No responsibility for this vehicle
                        MessageBox.Show("Sva odabrana vozila moraju imati odgovornog inspektora!");
                        return;
                    }
                }
            }

            DatabaseModel db = new DatabaseModel();
            var ci = new ControlInspector();

            //Insert this control to database
            control c = new control
            {
                company_id = this.companyId,
                start_date = controlDatePicker.Value,
                is_finished = 0,
                isActive = 1,
                is_regular = regularControl.Checked ? (sbyte)1 : (sbyte)0
            };
            db.controls.Add(c);
            db.SaveChanges();   //Must  be saved to get the auto generated id
            //Insert inspectors to control_has_inspectors table
            for (int i = 0; i < inspectorsGridView.SelectedRows.Count; i++)
            {
                var chi = new control_has_inspector()
                {
                    control_id = c.id,      //c.id already contains id because it is auto increment
                    inspector_id = (int)inspectorsGridView.SelectedRows[i].Cells["id"].Value
                };
                ci.control_has_inspector.Add(chi);
            }
            //Insert vehicle responsibilities
            if(this.noVehicles == false)
            {
                for (int i = 0; i < responsibilitiesGridView.Rows.Count; i++)
                {
                    var vr = new vehicle_responsibility()
                    {
                        control_id = c.id,      
                        inspector_id = (int)responsibilitiesGridView.Rows[i].Cells["inspector_id_column"].Value,
                        date = controlDatePicker.Value,
                        vehicle_id = (int)responsibilitiesGridView.Rows[i].Cells["vehicle_id_column"].Value
                    };
                    db.vehicle_responsibility.Add(vr);
                }
            }
            db.SaveChanges();
            ci.SaveChanges();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            selectedVehicles = new List<vehicle>();
            selectedInspectors = new List<inspector>();
            inspectorNames = new List<string>();
            inspectorNamesId = new Dictionary<string, int>();
            responsibilitiesGridView.Rows.Clear();
            for (int i = 0; i < vehiclesGridView.SelectedRows.Count; i++)
            {
                selectedVehicles.Add(new vehicle()
                {
                    id = (int)vehiclesGridView.SelectedRows[i].Cells["vehicle_id"].Value,
                    name = (string)vehiclesGridView.SelectedRows[i].Cells["nameData"].Value
                });
            }

            for (int i = 0; i < inspectorsGridView.SelectedRows.Count; i++)
            {
                selectedInspectors.Add(new inspector()
                {
                    id = (int)inspectorsGridView.SelectedRows[i].Cells["id"].Value,
                    first_name = (string)inspectorsGridView.SelectedRows[i].Cells["firstname"].Value + " " 
                                + (string)inspectorsGridView.SelectedRows[i].Cells["lastname"].Value,
                    username = (string)inspectorsGridView.SelectedRows[i].Cells["username"].Value
                });
                inspectorNames.Add(selectedInspectors[i].first_name);
                inspectorNamesId.Add(selectedInspectors[i].first_name, selectedInspectors[i].id);

            }

            //now add this to new gridview
            foreach(var v in selectedVehicles)
            {
                string[] row = { v.name, null, null, v.id.ToString() };
                responsibilitiesGridView.Rows.Add(row);
            }

            this.inspectorResponsibilityColumn.DataSource = inspectorNames;
        }

        private void responsibilitiesGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < responsibilitiesGridView.Rows.Count; i++)
            {
                string inspName = (string)responsibilitiesGridView.Rows[i].Cells["inspectorResponsibilityColumn"].Value;
                if (inspName != null)
                {
                    responsibilitiesGridView.Rows[i].Cells["inspector_id_column"].Value = inspectorNamesId[inspName];
                }
                else
                {
                    responsibilitiesGridView.Rows[i].Cells["inspector_id_column"].Value = "";
                }
            }
        }

        public void setTitleLabel(string text)
        {
            this.titleLabel.Text = text;
        }


    }
}

