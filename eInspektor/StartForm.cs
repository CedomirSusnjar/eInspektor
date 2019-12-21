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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.startForm = this;
            d.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarsView d = new CarsView();
            d.startForm = this;
            d.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InspectorView d = new InspectorView();
            d.startForm = this;
            d.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
