using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Circle_pyramid : Circle
    {
        private double pyramidHeight;

        public Circle_pyramid(double radius, double pyramidHeight) : base(radius)
        {
            this.pyramidHeight = pyramidHeight;
        }

        private double Get_Ploshad()
        {
            double x = Math.PI * radius * Math.Sqrt(radius * radius + pyramidHeight * pyramidHeight);
            return Ploshad() + x;
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

