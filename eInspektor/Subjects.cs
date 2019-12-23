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
    public partial class Subjects : Form
    {
        public StartForm startForm { get; set; }
        public Subjects()
        {
            InitializeComponent();
            startForm = new StartForm();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            startForm.Show();
        }
    }
}
