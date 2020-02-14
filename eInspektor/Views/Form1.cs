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
            if (!db.Database.Exists())
            {
                button1.Enabled = false;
                usernameTb.Enabled = false;
                passwordTb.Enabled = false;
                databasefailLbl.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;

            if (username.Length == 0 || password.Length == 0) {
                failedLoginLbl.Visible = true;
                return;
            }

            var queryAdmin = from v in db.admins
                         where v.username == username
                         select new
                         {
                             id = v.id,
                             password_hash = v.password_hash,
                             salt = v.salt
                         };

            if (queryAdmin.ToList().Count() == 0)
            {
                var queryUser = from v in db.inspectors
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
                if (queryUser.ToList().Count() == 0)
                {
                    failedLoginLbl.Visible = true;
                }
                else
                {
                    failedLoginLbl.Visible = false;
                    string hash = generateHash(password, queryUser.ToList().First().salt);

                    if (hash == queryUser.ToList().First().password_hash)
                    {
                        new StartForm(queryUser.ToList().First().id, queryUser.ToList().First().is_coordinator, queryUser.ToList().First().first_name, queryUser.ToList().First().last_name).Show();
                        Hide();
                    }
                    else
                    {
                        usernameTb.Text = "";
                        passwordTb.Text = "";
                        failedLoginLbl.Visible = true;
                    }
                }               
            }
            else
            {
                failedLoginLbl.Visible = false;
                string hash = generateHash(password, queryAdmin.ToList().First().salt);
                             
                if (hash == queryAdmin.ToList().First().password_hash)
                   {                       
                       int id = queryAdmin.ToList().First().id;
                       new AdminView(id,username).Show();
                       Hide();
                   }
                else
                  {
                       usernameTb.Text = "";
                       passwordTb.Text = "";
                       failedLoginLbl.Visible = true;
                }               
            }
                         
        }

        public static string generateHash(string password, string salt)
        {
             using (SHA512 sha512Hash = SHA512.Create())
                 {
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(salt + password);
                    byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                    return BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                 }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
