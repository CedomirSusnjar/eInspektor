﻿using eInspektor.Views;
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
    public partial class StartForm : Form
    {
        sbyte is_coordinator;
        string firstName, lastName;
        public int id;
        public StartForm(int id, sbyte is_coordinator,string firstName,string lastName)
        {
            InitializeComponent();
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.is_coordinator = is_coordinator;
            loggedUsername.Text = firstName + " " + lastName + ", " + (is_coordinator == 1? "koordinator":"");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plan d = new Plan();
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
            Reclamation d = new Reclamation();
            d.startForm = this;
            d.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Subjects d = new Subjects();
            d.startForm = this;
            d.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports d = new Reports();
            d.startForm = this;
            d.Show();
            Hide();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            resizeImages();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            if (imgToResize == null || size == null)
                return null;
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void resizeImages()
        {
            this.button1.Image = resizeImage(this.button1Image, new Size(this.tableLayoutPanel1.Width / 3 - 6, this.tableLayoutPanel1.Height / 3 - 6));
            this.button2.Image = resizeImage(this.button2Image, new Size(this.tableLayoutPanel1.Width / 3 - 6, this.tableLayoutPanel1.Height / 3 - 6));
            this.button3.Image = resizeImage(this.button3Image, new Size(this.tableLayoutPanel1.Width / 3 - 6, this.tableLayoutPanel1.Height / 3 - 6));
            this.button4.Image = resizeImage(this.button4Image, new Size(this.tableLayoutPanel1.Width / 3 - 6, this.tableLayoutPanel1.Height / 3 - 6));
            this.button5.Image = resizeImage(this.button5Image, new Size(this.tableLayoutPanel1.Width / 3 - 6, this.tableLayoutPanel1.Height / 3 - 6));
            this.button6.Image = resizeImage(this.button6Image, new Size(this.tableLayoutPanel1.Width / 3 - 6, this.tableLayoutPanel1.Height / 3 - 6));
        }

        private void StartForm_Resize(object sender, EventArgs e)
        {
            resizeImages();
        }

        private void promjenaLozinkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePswd(id, false).Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
