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
        bool isAdmin;
        DatabaseModel db;
        public ChangePswd(int id, bool isAdmin)
        {
            InitializeComponent();
            this.id = id;
            this.isAdmin = isAdmin;
            db = new DatabaseModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old = oldPswd.Text;
            string newPwd = newPswd.Text;

            if (newPwd.Length < 9)
            {
                shortPswdLbl.Visible = true;
            }
            else
            {
                shortPswdLbl.Visible = false;
                if (isAdmin)
                {
                    var queryAdmin = from v in db.admins
                                     where v.id == this.id
                                     select new
                                     {
                                         password_hash = v.password_hash,
                                         salt = v.salt
                                     };
                    changePassword(newPwd, old, queryAdmin.ToList().First().password_hash, queryAdmin.ToList().First().salt,true);
                }
                else
                {
                    var queryUser = from v in db.inspectors
                                    where v.id == this.id
                                    select new
                                    {
                                        password_hash = v.password_hash,
                                        salt = v.salt
                                    };

                    changePassword(newPwd, old, queryUser.ToList().First().password_hash, queryUser.ToList().First().salt,false);
                }
            }
        }

        private void changePassword(string newPwd, string old, string password_hash, string salt, bool isAdmin)
        {
            string hash = Form1.generateHash(old, salt);      
            if (password_hash == hash)
            {
                string hash1 = Form1.generateHash(newPwd, salt);
                if (isAdmin)
                {
                   var result = db.admins.SingleOrDefault(b => b.id == id);
                   result.password_hash = hash1;
                }
                else
                {
                    var result = db.inspectors.SingleOrDefault(b => b.id == id);
                    result.password_hash = hash1;
                }                          
                db.SaveChanges();
                Close();
            }
            else
            {
                failedChangepswdLbl.Visible = true;
            }
        }
    }
}
