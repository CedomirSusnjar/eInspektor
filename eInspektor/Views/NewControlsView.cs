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
                    return;
                }
            }
            //TODO add all to database



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
    }
}

