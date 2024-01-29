using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_29_listbox
{
    internal class Dolgozo
    {
        ulong id;
        string nev;
        DateTime szulido;

        public ulong Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szulido { get => szulido; set => szulido = value; }

        public Dolgozo(ulong id, string nev, DateTime szulido)
        {
            Id = id;
            Nev = nev;
            Szulido = szulido;
        }

        public int Kor()
        {
            return DateTime.Now.Year - szulido.Year;
        }
        public override string ToString()
        {
            return $"{this.nev} ({this.Kor()})";
        }
        public string toTxt()
        {
            return $"{id};{this.nev};{szulido.ToString("yyyy-MM-dd")}";
        }
    }
}
