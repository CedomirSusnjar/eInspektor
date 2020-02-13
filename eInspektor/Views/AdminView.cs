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
    public partial class AdminView : Form
    {
        int id;
        string username;

        public AdminView(int id, string username)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSources.inspector' table. You can move, or remove it, as needed.
            this.inspectorTableAdapter.Fill(this.dataSources.inspector);
            // TODO: This line of code loads data into the '_is_projDataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this._is_projDataSet.admin);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void promjenaLozinkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePswd(id, true).Show();
        }

        private void odjavaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }
    }
}
