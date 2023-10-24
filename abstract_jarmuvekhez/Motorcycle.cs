using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_jarmuvekhez
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string rendszam, string model) : base(rendszam, model)
        {
        }

        public override void Start()
        {
            Console.WriteLine($"Starting the {Model} ({Rendszam}) motorcycle.");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping the {Model} ({Rendszam}) motorcycle.");
        }
    }
}
