using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_27_abstract
{
    internal class Negyzet : Sikidom
    {
        public double oldal;

        public Negyzet(string tipus, double oldal): base(tipus) 
        {
            this.oldal = oldal;
        }

        public override double Kerulet()
        {
            return 4 * oldal;
        }

        public override double Terulet()
        {
            return oldal * oldal;
        }
    }
}
