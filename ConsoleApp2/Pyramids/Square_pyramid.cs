using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    namespace ConsoleApp2
    {
        class Square_pyramid : Square
        {
            private double pyramidHeight;

            public Square_pyramid(double storona, double pyramidHeight) : base(storona)
            {
                this.pyramidHeight = pyramidHeight;
            }

            private double Get_Ploshad()
            {
                double x = Math.Sqrt((storona / 2) * (storona / 2) + pyramidHeight * pyramidHeight);

                return Ploshad() + 4 * (0.5 * storona * x);
            }

            private double Volume()
            {
                return (1.0 / 3) * Ploshad() * pyramidHeight;
            }

            public new void Out()
            {
                Console.WriteLine($"Площадь полной поверхности: {Get_Ploshad()}");
                Console.WriteLine($"Объем пирамиды: {Volume()}");
            }
        }
    }
}