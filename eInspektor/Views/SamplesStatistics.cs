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
    public partial class SamplesStatistics : Form
    {
        DatabaseModel db;
        Reports report;
        public SamplesStatistics(Reports report)
        {
            InitializeComponent();
            db = new DatabaseModel();
            this.report = report;
        }

        private void SamplesStatistics_Load(object sender, EventArgs e)
        {
            var query = from v in db.lab_sample
                        select new
                        {
                            id = v.id,
                            company_id = v.company_id,
                            inspector_id = v.inspector_id,
                            date = v.date,
                            description = v.description
                        };
            var list = query.ToList();


            Dictionary<int, Tuple<Tuple<string, string>, Tuple<string,DateTime>>> triple = new Dictionary<int, Tuple<Tuple<string, string>, Tuple<string,DateTime>>>();

            foreach (dynamic item in list)
            {
                int cid = item.company_id;
                int iid = item.inspector_id;
               
                var queryCompany1 = from v in db.companies
                                   where v.id == cid
                                   select v.name;
               
                var queryInspector1 = from v in db.inspectors
                                     where v.id == iid
                                     select new
                                     {
                                         full_name = v.first_name + " " + v.last_name
                                     };

                string insp_name = queryInspector1.ToList().First().full_name;
                string company_name = queryCompany1.ToList().First();

                triple.Add(item.id, new Tuple<Tuple<string, string>, Tuple<string,DateTime>>(new Tuple<string, string>(insp_name, item.description),new Tuple<string, DateTime>(company_name,item.date)));
            }

            samplesGV.RowCount = triple.Count;
            for (int i = 0; i < triple.Count; i++)
            {
                samplesGV.Rows[i].Cells["company"].Value = triple.ElementAt(i).Value.Item2.Item1;
                samplesGV.Rows[i].Cells["inspector"].Value = triple.ElementAt(i).Value.Item1.Item1;
                samplesGV.Rows[i].Cells["date"].Value = triple.ElementAt(i).Value.Item2.Item2;
                samplesGV.Rows[i].Cells["description"].Value = triple.ElementAt(i).Value.Item1.Item2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchTb.Text == "")
            {
                for (int i = 0; i < samplesGV.RowCount; i++)
                {
                    samplesGV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < samplesGV.RowCount; i++)
                {                  
                        if (!samplesGV.Rows[i].Cells["inspector"].Value.ToString().Contains(searchTb.Text))
                            samplesGV.Rows[i].Visible = false;                                                
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchTB1.Text == "")
            {
                for (int i = 0; i < samplesGV.RowCount; i++)
                {
                    samplesGV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < samplesGV.RowCount; i++)
                {
                    if (!samplesGV.Rows[i].Cells["company"].Value.ToString().Contains(searchTB1.Text))
                        samplesGV.Rows[i].Visible = false;
                }
            }
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.Show();
            Close();
        }
    }

}