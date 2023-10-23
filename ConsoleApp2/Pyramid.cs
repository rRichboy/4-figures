﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pyramid
    {
        private double baseSide;
        private double height;
        private int numberOfSides;

        public Pyramid(double baseSide, double height, int numberOfSides)
        {
            this.baseSide = baseSide;
            this.height = height;
            this.numberOfSides = numberOfSides;
        }

        private double Ploshad()
        {
            double baseArea = baseSide * baseSide;
            double lateralArea = numberOfSides * baseSide * height / 2;
            return baseArea + lateralArea;
        }

        private double Obyom()
        {
            double baseArea = baseSide * baseSide;
            return (baseArea * height) / 3;
        }

        private double Perimeter()
        {
            return baseSide * numberOfSides;
        }

        public void Out()
        {
            Console.WriteLine($"Площадь поверхности пирамиды: {Ploshad()}");
            Console.WriteLine($"Объем пирамиды: {Obyom()}");
            Console.WriteLine($"Периметр основания пирамиды: {Perimeter()}");
        }

    }
}
