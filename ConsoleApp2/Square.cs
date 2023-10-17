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

        public double Perimeter()
        { return (4*storona); }
                
        public double Ploshad()
        { return (storona*storona); }

    }
}
