using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_pelda
{

    class Program
    {
        static void Main()
        {
            // Példa használat
            Circle circle = new Circle(5);
            circle.Draw();
            Console.WriteLine($"Circle area: {circle.Area()}");

            Square square = new Square(4);
            square.Draw();
            Console.WriteLine($"Square area: {square.Area()}");
            square.Resize(1.5);

            // Interfész típusa szerinti használat
            IDrawable drawable = square;
            drawable.Draw();

            IResizable resizable = square;
            resizable.Resize(2.0);
            Console.WriteLine("\nProgram vége");
            Console.ReadLine();
        }
    }

}
