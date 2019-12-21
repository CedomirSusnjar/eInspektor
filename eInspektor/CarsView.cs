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
    public partial class CarsView : Form
    {
        public StartForm startForm { get; set; }
        public CarsView()
        {
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }
    }
}
