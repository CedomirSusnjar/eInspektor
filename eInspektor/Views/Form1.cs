using eInspektor.Model;
using eInspektor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eInspektor
{
   
    public partial class Form1 : Form
    {
        private DatabaseModel db;
        public Form1()
        {
            InitializeComponent();
            db = new DatabaseModel();
        }

       

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;

            var query1 = from v in db.admins
                         where v.username == username
                         select new
                         {
                             id = v.id,
                             password_hash = v.password_hash,
                             salt = v.salt
                         };

            if (query1.ToList().Count() == 0)
            {
                var query = from v in db.inspectors
                            where v.username == username
                            select new
                            {
                                id = v.id,
                                salt = v.salt,
                                password_hash = v.password_hash,
                                username = v.username,
                                is_coordinator = v.is_coordinator,
                                first_name = v.first_name,
                                last_name = v.last_name
                            };

                if (query.ToList().Count() == 0)
                {
                    failedLoginLbl.Visible = true;
                }
                else
                {
                    failedLoginLbl.Visible = false;
                    string passwordhash = query.ToList().First().password_hash;
                    string salt = query.ToList().First().salt;

                    using (SHA512 sha512Hash = SHA512.Create())
                    {
                        byte[] sourceBytes = Encoding.UTF8.GetBytes(salt + password);
                        byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                        string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                        if (hash == passwordhash)
                        {
                            sbyte is_coordinator = query.ToList().First().is_coordinator;
                            string firstName = query.ToList().First().first_name;
                            string lastName = query.ToList().First().last_name;
                            int id = query.ToList().First().id;
                            new StartForm(id, is_coordinator, firstName, lastName).Show();
                            Hide();
                        }
                        else
                        {
                            usernameTb.Text = "";
                            passwordTb.Text = "";
                        }
                    }


                }
            }
            else
            {

                failedLoginLbl.Visible = false;
                string passwordhash = query1.ToList().First().password_hash;
                string salt = query1.ToList().First().salt;

                using (SHA512 sha512Hash = SHA512.Create())
                {
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(salt + password);
                    byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                    if (hash == passwordhash)
                    {                       
                        int id = query1.ToList().First().id;
                        new AdminView(id,username).Show();
                        Hide();
                    }
                    else
                    {
                        usernameTb.Text = "";
                        passwordTb.Text = "";
                    }
                }
            }
                         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {          
        }
    }
}
