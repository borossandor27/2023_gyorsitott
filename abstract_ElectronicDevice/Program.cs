using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ElectronicDevice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicDevice tv = new TV("Sony");
            ElectronicDevice phone = new Smartphone("iPhone");

            tv.TurnOn();
            tv.TurnOff();

            phone.TurnOn();
            phone.TurnOff();
            Console.WriteLine("\nProgram vége!");
            Console.ReadLine();
        }
    }
}
