using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ElectronicDevice
{
    public class TV : ElectronicDevice
    {
        public TV(string model):base(model)
        {
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Model} TV is turning off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Model} TV is turning on.");
        }
    }
}
