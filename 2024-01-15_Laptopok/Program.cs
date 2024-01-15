using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_01_15_Laptopok
{
    internal static class Program
    {
        public static List<Laptop> laptopok = new List<Laptop>();
        public static Adatbazis db = null;
        public static FormNyito formNyito = null;
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            db = new Adatbazis();
            laptopok=db.getAllLaptop();
            formNyito=new FormNyito();
            Application.Run(formNyito);
        }
    }
}
