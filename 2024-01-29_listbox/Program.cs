using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_01_29_listbox
{
    internal static class Program
    {
        public static Form1 nyitoForm = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            nyitoForm = new Form1();
            Application.Run(nyitoForm);
        }
    }
}
