using ConsoleApp2;

class main
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Квадрат\n2. Круг\n3. Прямоугольник\n4. Треугольник\n5. Выйти");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите сторону квадрата");
                    double storona = double.Parse(Console.ReadLine());
                    Square square = new Square(storona);
                    Console.WriteLine($"Площадь квадрата: {square.Ploshad()}");
                    Console.WriteLine($"Периметр квадрата: {square.Perimeter()}");
                    break;

                case 2:
                    Console.WriteLine("Введите радиус круга");
                    double radius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    Console.WriteLine($"Площадь круга: {circle.Ploshad()}");
                    Console.WriteLine($"Периметр круга: {circle.Perimeter()}");
                    break;

                case 3:
                    Console.WriteLine("Введите ширину прямоугольника");
                    double widht = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину прямоугольника");
                    double height = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(widht, height);
                    Console.WriteLine($"Площадь квадрата: {rectangle.Ploshad()}");
                    Console.WriteLine($"Периметр квадрата: {rectangle.Perimeter()}");
                    break;

                case 4:
                    Console.WriteLine("Введите A сторону треугольника");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B сторону треугольника");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите C сторону треугольника");
                    double sideC = double.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(sideA, sideB, sideC);
                    Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} является {triangle.GetTriangleType()}.");
                    Console.WriteLine($"Площадь треугольника: {triangle.Ploshad()}");
                    Console.WriteLine($"Периметр треугольника: {triangle.Perimeter()}");
                    break;

                case 5:
                    Console.WriteLine("Программа завершена.");
                    return;
            }
        }
    }
}