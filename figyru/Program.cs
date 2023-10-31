using Pryamoygol;

using Circles;
using Treygol;
using figures;

Rectangle rectangle = new Rectangle();
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

        if (choise == 2)
        {
            Console.WriteLine("Прямоугольник\n\n");
            Console.Write("Введи 1 сторону прямоугольника: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введи 2 сторону прямоугольника: ");
            float b = float.Parse(Console.ReadLine());
            Console.Clear();
            rectangle.Perimetr(a, b);
            rectangle.Ploshad(a, b);
        }
        if (choise == 3)
        {
            Console.WriteLine("Круг (но не Миша)");
            Console.Write("Введи радиус круга: ");
            float r = float.Parse(Console.ReadLine());
            Circle.Perimetr(r);
            Circle.Ploshad(r);
        }
        if (choise == 4)
        {
            Console.WriteLine("Треугольник");

            Console.Write("Сторона a): ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Сторона b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Сторона c: ");
            float c = float.Parse(Console.ReadLine());

            treygol.Perimetr(a, b, c);
            treygol.Ploshad(a, b, c);
            treygol.vid(a, b, c);
        }
        if (choise == 5)
        {
            Console.WriteLine("Пирамидки");
            Console.WriteLine("Выберите основание пирамидки: \n1 - Круг(но не Миша)\n2 - Квадрат\n3 - Прямоугольник\n4 - Треугольник");
            int what = int.Parse(Console.ReadLine());

            if (what == 1)
            {
                 
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

            }

            if (what == 3)
            {

            }

            if (what == 4)
            {

            }
        }
    }
}
