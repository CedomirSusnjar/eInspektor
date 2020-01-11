﻿using System;
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
        private DatabaseModel db;
        public StartForm startForm { get; set; }
        public Subjects()
        {
            InitializeComponent();           
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            startForm.Show();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            db = new DatabaseModel();
            var allCompanies = (from c in db.companies select c).ToList();
            dataGridView1.DataSource = allCompanies;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                startForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ukloniToolStripMenuItem_Click(object sender, EventArgs e)
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

                company c = db.companies.Find(id);
                if (c == null)
                {
                    continue;
                }
                db.companies.Remove(c);
            }
            db.SaveChanges();
            Subjects_Load(sender, e);
        }

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            company c = new company();
            c.bookkeeper = "New";
            c.jib = 0;
            c.name = "New";
            c.owner = "New";
        
            db.companies.Add(c);
            db.SaveChanges();
            Subjects_Load(sender, e);
        }
    }
}
