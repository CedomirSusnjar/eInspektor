using eInspektor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eInspektor.Views
{
    public partial class NewLabSample : Form
    {
        public NewLabSample()
        {
            InitializeComponent();
        }

        private void NewLabSample_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.FillByIsActive(this.dataSources.company);
            this.inspectorTableAdapter.FillByIsActive(this.dataSources.inspector);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check selected rows
            if(inspectorsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Odaberite jednog inspektora.");
                return;
            }
            if (companiesGridVew.SelectedRows.Count != 1)
            {
                MessageBox.Show("Odaberite jednu firmu.");
                return;
            }
            if ("".Equals(textBox1.Text.Trim()))
            {
                MessageBox.Show("Unesite u polje za opis.");
                return;
            }

            var db = new DatabaseModel();
            lab_sample ls = new lab_sample()
            {
                date = dateTimePicker1.Value,
                description = textBox1.Text,
                isActive = (sbyte)1,
                inspector_id = (int)inspectorsGridView.SelectedRows[0].Cells["idInspector"].Value,
                company_id = (int)companiesGridVew.SelectedRows[0].Cells["idCompany"].Value
            };

            db.lab_sample.Add(ls);
            db.SaveChanges();

            MessageBox.Show("Uspješno ste dodali uzorak.");
            this.Close();
        }
    }
}
