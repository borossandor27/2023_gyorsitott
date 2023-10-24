using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_jarmuvekhez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("ABC-123","Toyota");
            Vehicle motorcycle = new Motorcycle("CBA-456","Honda");

            car.Start();
            car.Stop();

            motorcycle.Start();
            motorcycle.Stop();

            Console.WriteLine( "\nProgram vége!");
            Console.ReadLine();
        }
    }
}
