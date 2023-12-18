using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    internal static class Program
    {
        public static FormMain formMain = null;
        public static Adatbazis db = new Adatbazis();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain(); // FormMain példányosítása
            Application.Run(new FormLogin());
        }
    }
}
