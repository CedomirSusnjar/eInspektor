using eInspektor.Model;
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

        async public Task<int> progressBarLoad() {
            for (int i = 0; i < 12; i++)
            {
                progressBar1.PerformStep();
                await Task.Delay(200);
            }
            return 1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;
            progressBarLoad();
            //TODO SQL injection

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

            if (query.ToList().Count()==0)
            {
                failedLoginLbl.Visible = true;
                progressBar1.Value = 0;
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
                        for (int i = 0; i < 8; i++)
                        {
                            progressBar1.PerformStep();
                            await Task.Delay(200);
                        }
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
                        progressBar1.Value = 0;
                    }
                }

            
            }



        }

        static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA512Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[i] = salt[i];
            }
            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[salt.Length + i] = plainText[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
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
    }
}
