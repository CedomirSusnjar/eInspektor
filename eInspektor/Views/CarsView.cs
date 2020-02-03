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
        private bool hasChanges;
        public StartForm startForm { get; set; }
        public CarsView()
        {
            InitializeComponent();
            hasChanges = false;
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarsView_Load(object sender, EventArgs e)
        {
            this.vehicleTableAdapter2.Fill(this.dataSources.vehicle);
            vehicleGridView.DataSource = this.dataSources.vehicle;
            db = new DatabaseModel();
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.hasChanges)
                {
                    DialogResult result = MessageBox.Show("Izmjene nisu sačuvane. Želite li ih sačuvati prije nego što napustite rad sa vozilima?", "Vozila", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes || result == DialogResult.No)
                    {
                        if (result == DialogResult.Yes)
                        {
                            //Save changes
                            sačuvajToolStripMenuItem_Click(null, e);
                        }
                        await Task.Delay(100);      //Doesn't work othervise
                        base.OnFormClosing(e);
                        this.Close();
                        startForm.Show();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else{
                    //There has been no modifications to table
                    base.OnFormClosing(e);
                    startForm.Show();
                }
            }            
        }

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.vehicleTableAdapter2.Update(this.dataSources.vehicle);
        }


        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(vehicleGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijedno vozilo.");
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati odabrana vozila?", "Brisanje vozila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                int selIndex = vehicleGridView.SelectedRows[0].Index;
                for (int i = 0; i < vehicleGridView.SelectedRows.Count; i++) 
                {
                    int id = 0;
                    try
                    {
                        id = (int)vehicleGridView.SelectedRows[i].Cells[0].Value;
                    }
                    catch (NullReferenceException)
                    {
                        //the row is already deleted
                        continue;
                    }

                    vehicle v = db.vehicles.Find(id);
                    if (v != null)
                    {
                        db.vehicles.Remove(v);
                    }                }
                db.SaveChanges();
                CarsView_Load(sender, e);
                if(selIndex != 0 && selIndex < vehicleGridView.Rows.Count)
                {
                    vehicleGridView.Rows[selIndex - 1].Selected = true;
                }
            }
           
        }

        private void dataGridView2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["isActive1"].Value = 1;
        }

        private void vehicleGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.hasChanges = true;
        }
    }
}
