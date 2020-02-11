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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;
            string hash;

            byte[] passwordByte = Convert.FromBase64String("password");
            byte[] saltByte = Convert.FromBase64String("salt");

            byte[] hashByte = GenerateSaltedHash(passwordByte, saltByte);

            string hashString = Convert.ToBase64String(hashByte);
            usernameTb.Text = hashString;
 
            if (true)
            {
                new StartForm().Show();
                Hide();
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
