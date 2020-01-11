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
    public partial class Reclamation : Form
    {
        private DatabaseModel db;
        public StartForm startForm { get; set; }
        public Reclamation()
        {
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void Reclamation_Load(object sender, EventArgs e)
        {
            db = new DatabaseModel();
            var allComplaints = (from c in db.complaints select c).ToList();
            dataGridView1.DataSource = allComplaints;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                startForm.Show();
        }

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            complaint c = new complaint();
            c.date = DateTime.Now;
            c.text = "Nova žalba";
            c.company_id = 1;
            c.is_resolved = 0;
            //TODO company id set 

            db.complaints.Add(c);
            db.SaveChanges();
            Reclamation_Load(sender, e);
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var cell in dataGridView1.SelectedCells)
            {
                int id = 0;
                try
                {
                    id = (int)dataGridView1.CurrentCell.OwningRow.Cells[0].Value;
                }
                catch (NullReferenceException)
                {
                    continue;
                }

                complaint c = db.complaints.Find(id);
                if (c == null)
                {
                    continue;
                }
                db.complaints.Remove(c);
            }
            db.SaveChanges();
            Reclamation_Load(sender, e);
        }
    
    }
}
