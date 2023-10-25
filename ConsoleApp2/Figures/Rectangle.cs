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
        protected double width;
        protected double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        protected double Perimeter()
        { return (2 * (width + height)); }

        protected double Ploshad()
        { return (width * height); }

        public virtual void Out()
        {
            Console.WriteLine($"Площадь прямоугольника: {Ploshad()}");
            Console.WriteLine($"Периметр прямоугольника: {Perimeter()}");
        }
    }
}
