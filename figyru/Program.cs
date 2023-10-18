using Pryamoygol;
using Kvadrat;
using Circles;
using Treygol;
Rectangle rectangle = new Rectangle();
Square square = new Square();
Circle Circle = new Circle();
Treygolnik treygol = new Treygolnik();


Console.WriteLine("Welcome!");

while (true)
{
    Console.WriteLine("\n\nНад какой фигурой будем производить расчеты?\n1 - Квадрат\n2 - Прямоугольник\n3 - Круг\n4 - Треугольник");
    Console.WriteLine("");
    int choise = int.Parse(Console.ReadLine());
    Console.Clear();
    if (choise == 1)
    {
        Console.WriteLine("Квадрат\n\n");
        Console.Write("Введи сторону квадрата: ");
        float s = float.Parse(Console.ReadLine());
        Console.Clear();
        square.Perimetr(s);
        square.Ploshad(s);
    }
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

        Treygolnik.Perimetr(a, b, c);
        Treygolnik.Ploshad(a, b, c);

    }
}
