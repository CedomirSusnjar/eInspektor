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
    public partial class JointControl : Form
    {
        DatabaseModel db;
        public JointControl()
        {
            InitializeComponent();
            db = new DatabaseModel();
        }

        private void JointControl_Load(object sender, EventArgs e)
        {         
        }
    }
}
