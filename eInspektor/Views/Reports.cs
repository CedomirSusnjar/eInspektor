using eInspektor.Model;
using eInspektor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eInspektor
{
    public partial class Reports : Form
    {
        public StartForm startForm { get; set; }
        private DatabaseModel db;
        private Dictionary<int, string> companyIdNames;
        private Dictionary<string, int> companyNamesId;
        public Reports()
        {
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.controlTableAdapter.FillByActiveFinishedSort(this.dataSources.control);
            db = new DatabaseModel();

            var query = from com in db.companies
                        select new
                        {
                            id = com.id,
                            name = com.name
                        };

            companyIdNames = new Dictionary<int, string>();
            companyNamesId = new Dictionary<string, int>();
            foreach (dynamic item in query)
            {
                companyIdNames.Add(item.id, item.name);
                companyNamesId.Add(item.name, item.id);
            }

            fillCompanyNamesIntoTable();
        }

        private void fillCompanyNamesIntoTable()
        {
            for (int i = 0; i < reportsGridView.Rows.Count; i++)
            {
                int compId = (int)reportsGridView.Rows[i].Cells["company_id"].Value;
                reportsGridView.Rows[i].Cells["companyColumn"].Value = companyIdNames[compId];
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                startForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(searchTextBox.Text.Trim()))
            {
                Reports_Load(sender, e);
                return;
            }
            try
            {
                //% is for regex
                this.controlTableAdapter.FillByActiveFinishedFilter(this.dataSources.control, "%" + searchTextBox.Text + "%");      
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            fillCompanyNamesIntoTable();
        }

        private void detaljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(reportsGridView.SelectedRows.Count != 1)
            {
                //Msg to select a row
                var popup = new MessageForm();
                popup.Text = "Greška";
                popup.textLabel.Text = "Izaberite jedan red!";
                popup.ShowDialog(this);
                return;
            }

            string companyName = (string)reportsGridView.SelectedRows[0].Cells["companyColumn"].Value;
            string content = (string)reportsGridView.SelectedRows[0].Cells["report_content"].Value;

            var detailsWindow = new MessageForm();
            detailsWindow.Text = companyName;
            detailsWindow.textLabel.Text = content;
            detailsWindow.ShowDialog(this);
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kontroleSaDrugimOdjelimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new JointControl().Show();
        }

        private void uzorciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ss = new SamplesStatistics(this);
            ss.lastscreen = this;
            ss.Show();
        }

        private void kontroleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Controls().Show();
        }
    }
}
