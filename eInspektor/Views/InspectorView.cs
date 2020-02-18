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
using eInspektor.Views;

namespace eInspektor
{
    public partial class InspectorView : Form
    {
        private DatabaseModel db;
        private bool hasChanges;
        public StartForm startForm { get; set; }
        public InspectorView()
        {
            InitializeComponent();
            hasChanges = false;
        }
        
        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InspectorView_Load(object sender, EventArgs e)
        {
            this.inspectorTableAdapter.FillByIsActive(this.dataSources.inspector);
            this.dataGridView1.DataSource = this.dataSources.inspector;
            db = new DatabaseModel();
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.hasChanges)
                {
                    DialogResult result = MessageBox.Show("Izmjene nisu sačuvane. Želite li ih sačuvati prije nego što napustite rad sa nalozima?", "Nalozi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
            this.inspectorTableAdapter.Update(this.dataSources.inspector);
            this.hasChanges = false;
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijedan nalog.");
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati odabrane naloge?", "Brisanje naloga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                    inspector ins = db.inspectors.Find(id);
                    //check if user is deleting himself
                    if(ins.id == startForm.id)
                    {
                        MessageBox.Show("Ne možete obrisati trenutno aktivan nalog.");
                        return;
                    }

                    if (ins != null)
                    {
                        ins.isActive = 0;
                    }
                }
                db.SaveChanges();
                InspectorView_Load(sender, e);
                if (selIndex != 0 && selIndex < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[selIndex - 1].Selected = true;
                }
            }

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["is_active"].Value = 1;
            e.Row.Cells["is_coordinator"].Value = 1;
            e.Row.Cells["salt"].Value = "salt";         //TODO make this random
            e.Row.Cells["password_hash"].Value = "123"; //TODO make this meaningful

        }

        private void vehicleGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.hasChanges = true;
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInspectorView niv = new NewInspectorView();
            niv.ShowDialog();
            InspectorView_Load(sender, e);
        }
    }
}
