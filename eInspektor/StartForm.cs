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

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
