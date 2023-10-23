using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Perimeter()
        { return (2 * (width + height)); }

        public double Ploshad()
        { return (width * height); }

        public void Out()
        {
            Console.WriteLine($"Площадь прямоугольника: {Ploshad()}");
            Console.WriteLine($"Периметр прямоугольника: {Perimeter()}");
        }
    }
}
