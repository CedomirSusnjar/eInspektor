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
    public partial class SamplesStatistics : Form
    {
        DatabaseModel db;
        Reports report;
        private bool hasChanges = false;
        public Reports lastscreen;
        public SamplesStatistics(Reports report)
        {
            InitializeComponent();
            db = new DatabaseModel();
            this.report = report;
        }

        private void SamplesStatistics_Load(object sender, EventArgs e)
        {
            this.lab_sampleTableAdapter.FillByIsActive(this.dataSources.lab_sample);
            db = new DatabaseModel();
            insertNames();
            hasChanges = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ("".Equals(searchTB1.Text.Trim()))
            {
                SamplesStatistics_Load(sender, e);
                return;
            }
            try
            {
                //% is for regex
                this.lab_sampleTableAdapter.FillByActiveFilter(this.dataSources.lab_sample, "%" + searchTB1.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            insertNames();
        }

        private void sacuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO no changes possible?
        }

        private void insertNames()
        {
            for (int i = 0; i < samplesGV.Rows.Count; i++) 
            {
                samplesGV.Rows[i].Cells["companyColumn"].Value = db.companies.Find((int)samplesGV.Rows[i].Cells["companyid"].Value).name;
                samplesGV.Rows[i].Cells["inspectorColumn"].Value = db.inspectors.Find((int)samplesGV.Rows[i].Cells["inspectorid"].Value).first_name + " " + db.inspectors.Find((int)samplesGV.Rows[i].Cells["inspectorid"].Value).last_name;
            }
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
                            sacuvajToolStripMenuItem_Click(null, e);
                        }
                        await Task.Delay(100);      //Doesn't work othervise
                        base.OnFormClosing(e);
                        this.Close();
                        lastscreen.Show();
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
                    lastscreen.Show();
                }
            }
        }

        private void samplesGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            hasChanges = true;
        }

        private void brišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (samplesGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijedan uzorak.");
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati odabrane uzorke?", "Brisanje uzoraka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int selIndex = samplesGV.SelectedRows[0].Index;
                for (int i = 0; i < samplesGV.SelectedRows.Count; i++)
                {
                    int id = 0;
                    try
                    {
                        id = (int)samplesGV.SelectedRows[i].Cells["idColumn"].Value;
                    }
                    catch (NullReferenceException)
                    {
                        //the row is already deleted
                        continue;
                    }

                    lab_sample ls = db.lab_sample.Find(id);
                    
                    if (ls != null)
                    {
                        ls.isActive = 0;
                    }
                }
                db.SaveChanges();
                SamplesStatistics_Load(sender, e);
                if (selIndex != 0 && selIndex < samplesGV.Rows.Count)
                {
                    samplesGV.Rows[selIndex - 1].Selected = true;
                }
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLabSample ns = new NewLabSample();
            ns.ShowDialog();
            SamplesStatistics_Load(sender, e);
        }

    }
}