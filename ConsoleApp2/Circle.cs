using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        private double Perimeter()
        { return (2 * Math.PI * radius); }

        private double Ploshad()
        { return (Math.PI * (radius * radius)); }

        public void Out()
        {
            Console.WriteLine($"Площадь круга: {Ploshad()}");
            Console.WriteLine($"Периметр круга: {Perimeter()}");
        }

    }
}
