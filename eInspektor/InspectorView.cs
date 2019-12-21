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
    public partial class InspectorView : Form
    {
        public StartForm startForm { get; set; }
        public InspectorView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }
    }
}
