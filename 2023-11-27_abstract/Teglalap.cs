using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_27_abstract
{
    internal class Teglalap : Sikidom
    {
        public double oldalA;
        public double oldalB;

        public Teglalap(string tipus, double oldalA, double oldalB) : base(tipus)
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
        }

        public override double Kerulet()
        {
            return 2 * oldalA + 2 * oldalB;
        }

        public override double Terulet()
        {
            return oldalA * oldalB;
        }
    }
}
