using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;
using eInspektor.Model;

namespace eInspektor
{
    public partial class CarsView : Form
    {
        private DatabaseModel db;
        public StartForm startForm { get; set; }
        public CarsView()
        {
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Izmjene nisu sačuvane. Želite li ih sačuvati prije nego što napustite rad sa vozilima?", "Vozila", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                //sacuvaj
                this.Close();
                startForm.Show();
            }
           
        }

        private void CarsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_is_projDataSet.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.dataSources.vehicle);
            db = new DatabaseModel();
            var allVehicles = (from v in db.vehicles select v).ToList();
            dataGridView1.DataSource = allVehicles;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                startForm.Show();
        }

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehicle v = new vehicle();
            v.max_capacity = 0;
            v.registration_num = "temp";
            v.tag = "t";
            db.vehicles.Add(v);
            db.SaveChanges();
            CarsView_Load(sender, e);
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati odabrano vozilo?", "Brisanje vozila", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
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

                    vehicle v = db.vehicles.Find(id);
                    if (v == null)
                    {
                        continue;
                    }
                    db.vehicles.Remove(v);
                }
                db.SaveChanges();
                CarsView_Load(sender, e);
            }
           
        }

        private void CarsView_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSources2.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter2.Fill(this.dataSources2.vehicle);
            

        }
    }
}
