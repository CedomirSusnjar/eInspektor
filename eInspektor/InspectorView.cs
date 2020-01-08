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

            using(DatabaseModel db = new DatabaseModel())
            {
                var allInspectors = (from i in db.inspectors select i).ToList();

                foreach (var inspector in allInspectors)
                {
                    dataGridView1.Rows.Add(inspector.name, "surname placeholder", inspector.shift);
                }
            }

        }
        
        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void InspectorView_Load(object sender, EventArgs e)
        {
            //nazadToolStripMenuItem_Click(sender, e);
        }
    }
}
