using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle_pyramid : Rectangle
    {
        private double pyramidHeight;

        public Rectangle_pyramid(double width, double height, double pyramidHeight) : base(width, height)
        {
            this.pyramidHeight = pyramidHeight;
        }

        private double Get_Ploshad()
        {
            double x = width * Math.Sqrt(Math.Pow(height / 2, 2) + Math.Pow(pyramidHeight, 2)) + height * Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(pyramidHeight, 2));

            return Ploshad() + x; ;
        }

        public double Volume()
        {
            double baseArea = Ploshad();
            return (1.0 / 3) * baseArea * pyramidHeight;
        }

        public void Out()
        {
            Console.WriteLine($"Площадь полной поверхности: {Get_Ploshad()}");
            Console.WriteLine($"Объем пирамиды: {Volume()}");
        }
    }
}
