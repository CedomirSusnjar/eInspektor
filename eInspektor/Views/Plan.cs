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
        //private Dictionary<string, int> companyNamesId;
        private Dictionary<int, string> inspectorIdNames;
        //private Dictionary<string, int> inspectorNamesId;
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
            //controlsGridView.DataSource = this.dataSources.vehicle;

            db = new DatabaseModel();
            fillCompanyNamesIntoTable();
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

        }

        private void fillByIsActiveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.companyTableAdapter.FillByIsActive(this.dataSources.company);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByIsActiveToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.controlTableAdapter.FillByIsActive(this.dataSources.control);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
            inspectorIdNames = new Dictionary<int, string>();

            for (int i = 0; i < controlsGridView.Rows.Count; i++)
            {
                var query = from ins in db.inspectors where ins.id == (int)controlsGridView.Rows[i].Cells["id"].Value select ins;

                //var controlInspectorQuery = from ci in db.

            }

        }

    }
}
