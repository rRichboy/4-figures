using ConsoleApp2;

class main
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Квадрат\n2. Круг\n3. Прямоугольник\n4. Треугольник\n5. Пирамида\n6. Выйти");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите сторону квадрата");
                    double storona = double.Parse(Console.ReadLine());
                    Square square = new Square(storona);
                    square.Out();
                    break;

                case 2:
                    Console.WriteLine("Введите радиус круга");
                    double radius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    circle.Out();
                    break;

                case 3:
                    Console.WriteLine("Введите ширину прямоугольника");
                    double widht = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину прямоугольника");
                    double height = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(widht, height);
                    rectangle.Out();
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
                    triangle.Out();
                    break;

                case 5:
                    Console.WriteLine("Введите длину основания, высоту и количество сторон пирамиды:");
                    double baseSide = double.Parse(Console.ReadLine());
                    double height1 = double.Parse(Console.ReadLine());
                    int numberOfSides = int.Parse(Console.ReadLine());
                    Pyramid pyramid = new Pyramid(baseSide, height1, numberOfSides);
                    pyramid.Out();
                    break;

                case 6:
                    Console.WriteLine("Программа завершена.");
                    return;
            }
        }
    }
}