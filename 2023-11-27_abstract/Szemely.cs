using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_27_abstract
{
    internal class Szemely
    {
        private string nev;
        private double testsuly;

        public string Nev { get => nev; set => nev = value; }
        public double Testsuly
        {
            get => testsuly;
            set
            {
                if (value > 0)
                {
                    testsuly = value;
                }
                else
                {
                    throw new Exception("Testsúly nem lehet nulla vagy kevesebb!");
                }
            }
        }

        public Szemely(string nev, double testsuly)
        {
            Nev = nev;
            Testsuly = testsuly;
        }
        public override string ToString()
        {
            return $"{nev} nevű személy testsúlya: {testsuly}";
        }
    }
}
