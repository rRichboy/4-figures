using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public string GetTriangleType()
        {
            if (!IsValid())
            {
                return "Треугольник не существует";
            }
            else if (IsEquilateral())
            {
                return "Равносторонний треугольник";
            }
            else if (IsIsosceles())
            {
                return "Равнобедренный треугольник";
            }
            else if (IsScalene())
            {
                return "Разносторонний треугольник";
            }
            else
            {
                return "Неизвестный тип треугольника";
            }
        }

        private bool IsValid()
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }

        private bool IsIsosceles()
        {
            return sideA == sideB || sideB == sideC || sideA == sideC;
        }

        private bool IsEquilateral()
        {
            return sideA == sideB && sideB == sideC;
        }

        private bool IsScalene()
        {
            return sideA != sideB && sideB != sideC && sideA != sideC;
        }

        private double Perimeter()
        {
            return (sideA + sideB + sideC);
        }

        private double Ploshad()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public void Out()
        {
            Console.WriteLine($"Площадь треугольника: {Ploshad()}");
            Console.WriteLine($"Периметр треугольника: {Perimeter()}");
        }
    }
}
