using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ElectronicDevice
{
    public abstract class ElectronicDevice
    {
        string model;

        public string Model { get => model; set => model = value; }

        protected ElectronicDevice(string model)
        {
            Model = model;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
