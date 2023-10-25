using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle_pyramid : Triangle
    {
        private double pyramidHeight;

        public Triangle_pyramid(double sideA, double sideB, double sideC, double pyramidHeight) : base(sideA,sideB,sideC)
        {
            this.pyramidHeight = pyramidHeight;
        }

        private double Get_Ploshad()
        {
            double s = Perimeter() / 2;
            double triangleArea = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            return triangleArea;
        }

        private double Volume()
        {
            return (1.0 / 3) * Ploshad() * pyramidHeight;
        }

        public override void Out()
        {
            Console.WriteLine($"Площадь полной поверхности: {Get_Ploshad()}");
            Console.WriteLine($"Объем пирамиды: {Volume()}");
        }
    }

}
