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

            using (DatabaseModel db = new DatabaseModel())
            {
                var allVehicles = (from v in db.vehicles select v).ToList();

                foreach (var vehicle in allVehicles)
                {
                    dataGridView1.Rows.Add(vehicle.registration_num, vehicle.max_capacity, vehicle.tag);
                }
            }
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void CarsView_Load(object sender, EventArgs e)
        {
            //nazadToolStripMenuItem_Click(sender, e);
        }

        private void CarsView_Load_1(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                startForm.Show();
        }
    }
}
