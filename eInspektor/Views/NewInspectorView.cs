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
    public partial class NewInspectorView : Form
    {
        static Random rd = new Random();
        public NewInspectorView()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            if ("".Equals(tbName.Text.Trim())
                || "".Equals(tbLastname.Text.Trim())
                || "".Equals(tbUsername.Text.Trim())
                || "".Equals(tbPassword.Text.Trim())
                || "".Equals(tbDepartment.Text.Trim())
                || (radioFirst.Checked == false && radioSecond.Checked == false)
                ) {
                errorLabel.Text = "Popunite sva polja!";
                errorLabel.Visible = true;
                return;
            }
            if(tbPassword.Text.Length < 8)
            {
                errorLabel.Text = "Lozinka mora imati najmanje 8 karaktera!";
                errorLabel.Visible = true;
                return;
            }
            DatabaseModel db = new DatabaseModel();
            //check username duplicates
            var query = from insp in db.inspectors where insp.username == tbUsername.Text select insp;
            if(query.Count() != 0)
            {
                errorLabel.Text = "Postoji nalog sa tim korisničkim imenom!";
                errorLabel.Visible = true;
                return;
            }



            string salt = CreateString(4);
            inspector i = new inspector()
            {
                first_name = tbName.Text,
                last_name = tbLastname.Text,
                username = tbUsername.Text,
                department = tbDepartment.Text,
                isActive = (sbyte)1,
                is_coordinator = (sbyte)0,
                unavailable = (sbyte)0,
                shift = radioFirst.Checked ? 1 : 2,
                salt = salt,
                password_hash = Form1.generateHash(tbPassword.Text, salt)
            };

            db.inspectors.Add(i);
            db.SaveChanges();
            this.Close();
        }
        
        internal static string CreateString(int stringLength)
        {
            const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-";
            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
