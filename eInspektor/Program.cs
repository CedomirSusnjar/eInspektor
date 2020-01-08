using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eInspektor
{
    static class Program
    {
      
        static void Main()
        {
            //database example
            /*
            using(DatabaseModel dm = new DatabaseModel())
            {
                var inspector = new inspector()
                {
                    name = "Marko",
                    department = "kontrola",
                    is_coordinator = 1,
                    unavailable = 0,
                    shift = 1,
                    username = "marko",
                    salt = "salt",
                    password_hash = "hash"
                };
                dm.inspectors.Add(inspector);
                dm.SaveChanges();
            
            }*/
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
