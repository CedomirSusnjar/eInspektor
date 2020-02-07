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
            this.controlTableAdapter.FillByActiveAndFinished(this.dataSources.control);
            //reportsGridView.DataSource = this.dataSources.control;
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
            BindingSource bs = new BindingSource();
            bs.DataSource = reportsGridView.DataSource;
            //bs.Filter = reportsGridView.Columns["companyColumn"].HeaderText.ToString() + " LIKE '%" + searchTextBox.Text + "%'";
            //bs.Filter = "companyColumn LIKE '%" + searchTextBox.Text + "%'";           




            reportsGridView.DataSource = bs;
        }
    }
}
