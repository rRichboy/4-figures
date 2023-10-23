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
        private double storona;

        public Square(double storona)
        {
            this.storona = storona;
        }

        private double Perimeter()
        { return (4*storona); }
                
        private double Ploshad()
        { return (storona*storona); }

        public void Out()
        {
            Console.WriteLine($"Площадь квадрата: {Ploshad()}");
            Console.WriteLine($"Периметр квадрата: {Perimeter()}");
        }

    }
}
