using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Square
    {
        protected double storona;

        public Square(double storona)
        {
            this.storona = storona;
        }

        protected double Perimeter()
        { return (4*storona); }
                
        protected double Ploshad()
        { return (storona*storona); }

        public void Out()
        {
            Console.WriteLine($"Площадь квадрата: {Ploshad()}");
            Console.WriteLine($"Периметр квадрата: {Perimeter()}");
        }

    }
}
