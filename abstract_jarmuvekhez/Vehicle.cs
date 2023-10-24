using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_jarmuvekhez
{
    public abstract class Vehicle
    {
        string rendszam;
        string model;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Model { get => model; set => model = value; }

        protected Vehicle(string rendszam, string model)
        {
            Rendszam = rendszam;
            Model = model;
        }
        public abstract void Start();
        public abstract void Stop();
    }
}
