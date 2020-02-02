using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eInspektor.Model;

namespace eInspektor
{
    public partial class InspectorView : Form
    {
        private DatabaseModel db;
        public StartForm startForm { get; set; }
        public InspectorView()
        {
            InitializeComponent();
        }
        
        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Izmjene nisu sačuvane. Želite li ih sačuvati prije nego što napustite rad sa inspektorima?","Inspektori", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                //sacuvaj
                this.Close();
                startForm.Show();
            }
           
        }

        private void InspectorView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSources.inspector' table. You can move, or remove it, as needed.
            this.inspectorTableAdapter.Fill(this.dataSources.inspector);
            // TODO: This line of code loads data into the 'dataSources.joint_control' table. You can move, or remove it, as needed.
            this.joint_controlTableAdapter.Fill(this.dataSources.joint_control);
            db = new DatabaseModel();
            var allInspectors = (from i in db.inspectors select i).ToList();
            dataGridView1.DataSource = allInspectors;
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
            inspector i = new inspector();
            i.first_name = "New";
            i.last_name = "New";
            i.salt = "salt";
            i.password_hash = "123";
            i.shift = 0;
            i.unavailable = 0;

            Random r = new Random();
            i.username = "New" + r.Next(0,100);
            i.is_coordinator = 0;
            i.department = "Inspektori";
            // TODO: Password hash

            db.inspectors.Add(i);
            db.SaveChanges();
            InspectorView_Load(sender, e);
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da zelite obrisati odabranog inspektora?", "Brisanje inspektora", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
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

                    inspector i = db.inspectors.Find(id);
                    if (i == null)
                    {
                        continue;
                    }
                    db.inspectors.Remove(i);
                }
                db.SaveChanges();
                InspectorView_Load(sender, e);
            }
           
        }
    }
}
