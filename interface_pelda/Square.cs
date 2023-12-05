using System;

namespace interface_pelda
{
    // Négyzet osztály, ami az absztrakt osztályból örököl és implementálja mindkét interfészt
    public class Square : Shape, IDrawable, IResizable
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area()
        {
            return SideLength * SideLength;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a square with side length {SideLength}");
        }

        public void Resize(double factor)
        {
            SideLength *= factor;
            Console.WriteLine($"Resized square to new side length: {SideLength}");
        }
    }

}
