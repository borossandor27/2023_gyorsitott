using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ElectronicDevice
{
    internal class Smartphone : ElectronicDevice
    {
        public Smartphone(string model) : base(model)
        {
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Model} smartphone is turning off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Model} smartphone is turning on.");
        }
    }
}
