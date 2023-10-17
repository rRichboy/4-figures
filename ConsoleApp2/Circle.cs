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

        public double Perimeter()
        { return (2 * Math.PI * radius); }

        public double Ploshad()
        { return (Math.PI * (radius * radius)); }

    }
}
