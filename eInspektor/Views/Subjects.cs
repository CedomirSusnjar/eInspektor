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
    public partial class Subjects : Form
    {
        private DatabaseModel db;
        private bool hasChanges;
        public StartForm startForm { get; set; }
        public Subjects()
        {
            InitializeComponent();
            hasChanges = false;
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter1.FillByIsActive(this.dataSources1.company);
            db = new DatabaseModel();
        }
        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.hasChanges)
                {
                    DialogResult result = MessageBox.Show("Izmjene nisu sačuvane. Želite li ih sačuvati prije nego što napustite rad sa firmama?", "Firme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes || result == DialogResult.No)
                    {
                        if (result == DialogResult.Yes)
                        {
                            //Save changes
                            sačuvajToolStripMenuItem_Click(null, e);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ukloniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijednu firmu.");
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati odabrane firme?", "Brisanje firmi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int selIndex = dataGridView1.SelectedRows[0].Index;
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    int id = 0;
                    try
                    {
                        id = (int)dataGridView1.SelectedRows[i].Cells[0].Value;
                    }
                    catch (NullReferenceException)
                    {
                        //the row is already deleted
                        continue;
                    }

                    company v = db.companies.Find(id);
                    if (v != null)
                    {
                        v.isActive = 0;
                    }
                }
                db.SaveChanges();
                Subjects_Load(sender, e);
                if (selIndex != 0 && selIndex < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[selIndex - 1].Selected = true;
                }
            }
        }

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.companyTableAdapter1.Update(this.dataSources1.company);
            this.hasChanges = false;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["is_active"].Value = 1;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.hasChanges = true;
        }

    }
}
