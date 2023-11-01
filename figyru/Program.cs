

using Circles;
using Treygol;
using figures;

Circle Circle = new Circle();
Treygolnik treygol = new Treygolnik();



Console.WriteLine("Welcome!");

while (true)
{
    Console.WriteLine("\n\nНад какой фигурой будем производить расчеты?\n1 - Квадрат\n2 - Прямоугольник\n3 - Круг\n4 - Треугольник\n5 - Пирамидки");
    Console.WriteLine("");
    int choise = int.Parse(Console.ReadLine());
    Console.Clear();
    if (choise == 1)
    {
        Console.WriteLine("Квадрат\n\n");
        Console.Write("Введи сторону квадрата: ");
        double s = double.Parse(Console.ReadLine());
        Square Squarepiro = new Square(s);
        Console.Clear();
    }

        if (choise == 2)
        {
            Console.WriteLine("Прямоугольник\n\n");
            Console.Write("Введи 1 сторону прямоугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введи 2 сторону прямоугольника: ");
            double b = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(a, b);
        Console.Clear();
        rectangle.Out();
            
        }
        if (choise == 3)
        {
            Console.WriteLine("Круг (но не Миша)");
            Console.Write("Введи радиус круга: ");
            double r = double.Parse(Console.ReadLine());
            Circle.Perimetr(r);
            Circle.Ploshad(r);
        }
        if (choise == 4)
        {
            Console.WriteLine("Треугольник");

            Console.Write("Сторона a): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Сторона b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Сторона c: ");
            double c = double.Parse(Console.ReadLine());

            treygol.Perimetr(a, b, c);
            treygol.Ploshad(a, b, c);
            treygol.vid(a, b, c);
        }
        if (choise == 5)
        {
            Console.WriteLine("Пирамидки");
            Console.WriteLine("Выберите основание пирамидки: \n1 - Квадрат\n2 - Круг(но не Миша)\n3 - Прямоугольник\n4 - Треугольник");
            int what = int.Parse(Console.ReadLine());

            if (what == 1)
            {
                Console.Clear();
                Console.WriteLine("Квадратик пирамидка");
                Console.Write("Введите сторону квадрата для основания пирамидки: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите высоту: ");
                double h = double.Parse(Console.ReadLine());
                square_pyramid pyramid = new square_pyramid(a, h);
                Console.Clear();
                pyramid.Out();
                Console.WriteLine();
            }
        

            if (what == 2)
            {
            Console.Clear();
            Console.WriteLine(""); 

            }

            if (what == 3)
            {
            Console.Clear();
            Console.WriteLine("Прямоугольник пирамидка");
            Console.WriteLine("Введите сторону а для основания пирамидки: ");
            double a = double.Parse (Console.ReadLine());   
            Console.WriteLine("Введите сторону в для основания пирамидки: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту h: ");
            double h = double.Parse(Console.ReadLine());
            
            

            RectPiramida rectPiramida = new RectPiramida(a, b, h);

            Console.Clear();
            rectPiramida.Out();
        }

            if (what == 4)
            {

            }
        }
    }

