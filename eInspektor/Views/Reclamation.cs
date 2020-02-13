﻿using System;
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
        private Dictionary<int, string> companyIdNames;
        private List<string> companyNames;
        private Dictionary<string, int> companyNamesId;    
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

            this.complaintTableAdapter1.FillByIsActive(this.dataSources1.complaint);
            dataGridView1.DataSource = this.dataSources1.complaint;

            var query = from com in db.companies
                        select new
                        {
                            id = com.id,
                            name = com.name,
                            isActive = com.isActive
                        };

            companyIdNames = new Dictionary<int, string>();
            companyNames = new List<string>();
            companyNamesId = new Dictionary<string, int>();
            foreach (dynamic item in query)
            {
                companyIdNames.Add(item.id, item.name);
                companyNamesId.Add(item.name, item.id);
               // if (item.isActive != 0)                   //Constant errors with this check if reclamation on deleted subject exists
                {
                    companyNames.Add(item.name);
                }
            }
            this.company_name_column.DataSource = companyNames;

            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {                
                int compId = (int)dataGridView1.Rows[i].Cells["company_id"].Value;
                dataGridView1.Rows[i].Cells["company_name_column"].Value = companyIdNames[compId];
            }
            this.hasChanges = false;
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
            // update subjects name column
            //TODO company name should be unique (in database)
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)      //It doesn't need to fill new row
            {
                string compName = (string)dataGridView1.Rows[i].Cells["company_name_column"].Value;
                dataGridView1.Rows[i].Cells["company_id"].Value = companyNamesId[compName];
            }

            this.complaintTableAdapter1.Update(this.dataSources1.complaint);
            this.hasChanges = false;
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
                        v.isActive = 0;
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
            e.Row.Cells["company_name_column"].Value = companyNames[0];
            e.Row.Cells["is_active"].Value = 1;
            e.Row.Cells["date"].Value = DateTime.Now;
            e.Row.Cells["company_id"].Value = companyNamesId[companyNames[0]];
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.hasChanges = true;
        }

    }
}
