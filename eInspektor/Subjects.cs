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
    public partial class Subjects : Form
    {
        public StartForm startForm { get; set; }
        public Subjects()
        {
            InitializeComponent();
            startForm = new StartForm();

            using (DatabaseModel db = new DatabaseModel())
            {
                var allCompanies = (from c in db.companies select c).ToList();

                foreach (var company in allCompanies)
                {
                    dataGridView1.Rows.Add(company.name, "address placeholder", company.owner, company.last_control, "inspektor?");
                }
            }
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            startForm.Show();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                startForm.Show();
        }
    }
}
