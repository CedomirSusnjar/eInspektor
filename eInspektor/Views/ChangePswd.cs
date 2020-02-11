using eInspektor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eInspektor.Views
{
    public partial class ChangePswd : Form
    {
        int id;
        public ChangePswd(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old = oldPswd.Text;
            string newPwd = newPswd.Text;

            DatabaseModel db = new DatabaseModel();
            var query = from v in db.inspectors
                        where v.id == this.id
                        select v.password_hash;

            string passwordHash = query.ToList().First();

            using (SHA512 sha512Hash = SHA512.Create())
            {
                Console.WriteLine("ojsa");
                byte[] sourceBytes = Encoding.UTF8.GetBytes("salt" + old);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                if (passwordHash == hash) {//if not equal, message
                    Console.WriteLine("ojsa");
                    var result = db.inspectors.SingleOrDefault(b => b.id == id);
                    if (result != null)
                    {
                        Console.WriteLine("ojsa");
                        byte[] sourceBytes1 = Encoding.UTF8.GetBytes("salt" + newPwd);
                        byte[] hashBytes1 = sha512Hash.ComputeHash(sourceBytes1);
                        string hash1 = BitConverter.ToString(hashBytes1).Replace("-", String.Empty);
                        result.password_hash = hash1;
                        db.SaveChanges();
                        Close();
                    }
                }
            }

            }
    }
}
