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
    public partial class Reclamation : Form
    {
        private DatabaseModel db;
        private bool hasChanges;
        public StartForm startForm { get; set; }
        public Reclamation()
        {
            InitializeComponent();
            hasChanges = false;
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reclamation_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Fill(this.dataSources1.company);
            db = new DatabaseModel();

            this.complaintTableAdapter1.Fill(this.dataSources1.complaint);
            dataGridView1.DataSource = this.dataSources1.complaint;

            var query = from com in db.companies
                        select new
                        {
                            id = com.id,
                            name = com.name
                        };

            var companyIdNames = new Dictionary<int, string>();
            var companyNames = new List<string>();
            foreach(dynamic item in query)
            {
                companyIdNames.Add(item.id, item.name);
            }
            foreach (var item in companyIdNames)
            {
                companyNames.Add(item.Value);
            }
            this.company_name_column.DataSource = companyNames;

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int compId = (int)dataGridView1.Rows[i].Cells["company_id"].Value;
                dataGridView1.Rows[i].Cells["company_name_column"].Value = companyIdNames[compId];
            }

        }
        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.hasChanges)
                {
                    DialogResult result = MessageBox.Show("Izmjene nisu sačuvane. Želite li ih sačuvati prije nego što napustite rad sa reklamacijama?", "Reklamacije", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO check if company exists or disable changes on that column
            this.complaintTableAdapter1.Update(this.dataSources1.complaint);
            this.hasChanges = false;
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO open new window with apropriate input form
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijednu reklamaciju.");
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati odabrane reklamacije?", "Brisanje reklamacija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                    complaint v = db.complaints.Find(id);
                    if (v != null)
                    {
                        db.complaints.Remove(v);
                    }
                }
                db.SaveChanges();
                Reclamation_Load(sender, e);
                if (selIndex != 0 && selIndex < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[selIndex - 1].Selected = true;
                }
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["is_active"].Value = 1;
            e.Row.Cells["date"].Value = DateTime.Now;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.hasChanges = true;
        }
    }
}
