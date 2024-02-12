using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_12_DataGrid
{
    internal class Orszag
    {
        public string OrszagNev;
        public string Kontinens;
        public string Fovaros;
        public decimal Terulet;

        public Orszag(string orszag, string kontinens, string fovaros, decimal terulet)
        {
            OrszagNev = orszag;
            Kontinens = kontinens;
            Fovaros = fovaros;
            Terulet = terulet;
        }
    }
}
