using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCzigleczky
{
    internal class Orszag
    {
        public string Orszagnev { get; set; }
        public double Terulet { get; set; }

        public Orszag(string orszagnev, double terulet)
        {
            Orszagnev = orszagnev;
            Terulet = terulet;
        }
        override public string ToString()
        {
            return Orszagnev + " (" + Terulet.ToString("#,##0.0") + ")";
        }
    }
}
