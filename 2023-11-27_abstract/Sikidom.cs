using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_27_abstract
{
    abstract class Sikidom
    {
        public string tipus; //-- pl. kör, négyzet, ...
        abstract public double Kerulet();
        abstract public double Terulet();

        protected Sikidom(string tipus)
        {
            this.tipus = tipus;
        }
    }
}
