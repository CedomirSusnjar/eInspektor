﻿using eInspektor.Model;
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
    public partial class ReportView : Form
    {
        public int controlId;
        public ReportView()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DatabaseModel db = new DatabaseModel();
            control c = db.controls.Find(controlId);
            c.is_finished = (sbyte)1;
            c.finish_date = dateTimePicker1.Value;
            c.control_justified = cbJustified.Checked ? (sbyte)1 : (sbyte)0;
            c.report_content = tbContent.Text;

            foreach (var comp in c.complaints)
            {
                comp.is_resolved = (sbyte)1;
                comp.is_justified = c.control_justified;
            }

            //Update company last control date
            c.company.last_control = c.finish_date;
            
            db.SaveChanges();
            this.Close();
        }
    }
}
