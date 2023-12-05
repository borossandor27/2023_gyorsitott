using System;

namespace interface_pelda
{
    // Kör osztály, ami az absztrakt osztályból örököl és implementálja az IDrawable interfészt
    public class Circle : Shape, IDrawable
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radius}");
        }
    }

}
