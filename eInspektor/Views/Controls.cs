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
    public partial class Controls : Form
    {
        DatabaseModel db;
        public Controls()
        {
            InitializeComponent();
            db = new DatabaseModel();
        }

        private void Controls_Load(object sender, EventArgs e)
        {
            var query = from v in db.controls
                        select new
                        {

                        };
        }
    }
}
