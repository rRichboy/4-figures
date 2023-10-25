using ConsoleApp2;
using ConsoleApp2.ConsoleApp2;

class main
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Фигуры\n2. Пирамиды");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Квадрат\n2. Круг\n3. Прямоугольник\n4. Треугольник\n5. Пирамида\n6. Выйти");
                    int choice1 = int.Parse(Console.ReadLine());

                    switch (choice1)
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
                    break;

                case 2:
                    Console.WriteLine("1. Квадратная пирамида\n2. Прямоугольная пирамида\n3. Конус\n4. Треугольная пирамида\n5. Вернуться обратно\n6. Выйти");
                    int choice2 = int.Parse(Console.ReadLine());

                    switch (choice2)
                    {
                        case 1:
                            Console.Write("Введите длину стороны квадрата: ");
                            double storonaKvadrata = double.Parse(Console.ReadLine());

                            Console.Write("Введите высоту пирамиды: ");
                            double heightPyramid = double.Parse(Console.ReadLine());

                            Square_pyramid sqpyramid = new Square_pyramid(storonaKvadrata, heightPyramid);
                            sqpyramid.Out();
                            break;

                        case 2:
                            Console.Write("Введите длину прямоугольника: ");
                            double dlinaprymougol = double.Parse(Console.ReadLine());

                            Console.Write("Введите ширину прямоугольника: ");
                            double shirinaprymougol = double.Parse(Console.ReadLine());

                            Console.Write("Введите высоту пирамиды: ");
                            double heightPyramid1 = double.Parse(Console.ReadLine());

                            Rectangle_pyramid recpyramid = new Rectangle_pyramid(dlinaprymougol, shirinaprymougol, heightPyramid1);
                            recpyramid.Out();
                            break;

                        case 3:
                            Console.Write("Введите радиус круга: ");
                            double radius = double.Parse(Console.ReadLine());

                            Console.Write("Введите высоту пирамиды: ");
                            double heightPyramid2 = double.Parse(Console.ReadLine());

                            Circle_pyramid cirpyramid = new Circle_pyramid(radius, heightPyramid2);
                            cirpyramid.Out();
                            break;

                        case 4:
                            Console.WriteLine("Введите A сторону треугольника\nВведите B сторону треугольника\nВведите C сторону треугольника");
                            double sideA = double.Parse(Console.ReadLine());
                            double sideB = double.Parse(Console.ReadLine());
                            double sideC = double.Parse(Console.ReadLine());
                            Console.Write("Введите высоту пирамиды: ");
                            double heightPyramid3 = double.Parse(Console.ReadLine());
                            Triangle_pyramid tripyramid = new Triangle_pyramid(sideA,sideB,sideC, heightPyramid3);
                            tripyramid.Out();
                            break;

                        case 5:
                            break;

                        case 6:
                            Console.WriteLine("Программа завершена.");
                            return;
                    }
                    break;
            }
        }
    }
}
