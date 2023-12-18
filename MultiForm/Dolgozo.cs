using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm
{
    internal class Dolgozo
    {
        public ulong id;
        public string nev;
        public DateTime szuletett;
        public string nem;

        public Dolgozo(ulong id, string nev, DateTime szuletett, string nem)
        {
            this.id = id;
            this.nev = nev;
            this.szuletett = szuletett;
            this.nem = nem;
        }
    }
}
