


using Treygol;
using figures;
using figyru;
 void OutAll(int choise)
{
    switch (choise)
    {
        case 1 :
        {
            Console.WriteLine("Квадратик \nВведите сторону а: ");
        }
            break; 
        case 2 :
        {
            Console.WriteLine("Прямоугольник \nВведите стороны а и b (через enter): ");
        }
            break; 
        case 3 :
        {
            Console.WriteLine("Треугольник \nВведите сторону а, b и c (через enter):");
        }
            break; 
    }
    
}
Console.WriteLine("Welcome!");

 while (true)
 {
     Console.WriteLine(
         "\n\nНад какой фигурой будем производить расчеты?\n1 - Квадрат\n2 - Прямоугольник\n3 - Круг\n4 - Треугольник\n5 - Пирамидки");
     Console.WriteLine("");
     int choise = int.Parse(Console.ReadLine());
     Console.Clear();

     switch (choise)
     {
         case 1:
         {
             OutAll(choise);
             double a = double.Parse(Console.ReadLine());

             Square Square = new Square(a);

             Console.Clear();
             Square.Out();
         }
             break;

         case 2:
         {
             OutAll(2);
             double a = double.Parse(Console.ReadLine());
             double b = double.Parse(Console.ReadLine());

             Rectangle rectangle = new Rectangle(a, b);

             Console.Clear();
             rectangle.Out();
         }
             break;

         case 3:
         {
             Console.WriteLine("Круг (но не Миша)");
             Console.Write("Введи радиус круга: ");
             double r = double.Parse(Console.ReadLine());

             Circle circle = new Circle(r);

             Console.Clear();
             circle.Out();
         }
             break;
         case 4:
         {
             OutAll(3);
             double a = double.Parse(Console.ReadLine());

             double b = double.Parse(Console.ReadLine());

             double c = double.Parse(Console.ReadLine());

             Treygolnik treygol = new Treygolnik(a, b, c);

             Console.Clear();
             treygol.Out();
             treygol.vid(a, b, c);
         }
             break;

         case 5:
         {
             Console.WriteLine("Пирамидки");
             Console.WriteLine(
                 "Выберите основание пирамидки: \n1 - Квадрат\n2 - Круг(но не Миша)\n3 - Прямоугольник\n4 - Треугольник");
             int what = int.Parse(Console.ReadLine());

             switch (what)
             {
                 case 1:
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
                 }
                     break;
                 case 2:
                 {
                     Console.Clear();
                     Console.WriteLine("Круг пирамидка");
                     Console.WriteLine("Введите радиус круга для основания пирамидки: ");
                     double r = double.Parse(Console.ReadLine());

                     Console.WriteLine("Введите высоту: ");
                     double h = double.Parse(Console.ReadLine());

                     Circle pirocircle = new pirocircle(r, h);

                     Console.Clear();
                     pirocircle.Out();
                 }
                     break;

                 case 3:
                 {
                     Console.Clear();
                     Console.WriteLine("Прямоугольник пирамидка");
                     Console.WriteLine("Введите сторону а для основания пирамидки: ");
                     double a = double.Parse(Console.ReadLine());

                     Console.WriteLine("Введите сторону в для основания пирамидки: ");
                     double b = double.Parse(Console.ReadLine());

                     Console.WriteLine("Введите высоту h: ");
                     double h = double.Parse(Console.ReadLine());

                     RectPiramida rectPiramida = new RectPiramida(a, b, h);

                     Console.Clear();
                     rectPiramida.Out();
                 }
                     break;
                 case 4:
                 {
                     Console.Clear();
                     Console.WriteLine("Треугольная пирамидка");
                     Console.WriteLine("Введите сторону а: ");
                     double a = double.Parse(Console.ReadLine());

                     Console.WriteLine("Введите сторону в: ");
                     double b = double.Parse(Console.ReadLine());

                     Console.WriteLine("Введите сторону с: ");
                     double c = double.Parse(Console.ReadLine());

                     Console.WriteLine("Введите высоту h: ");
                     double h = double.Parse(Console.ReadLine());

                     pirotreygolnik pirotreygolnik = new pirotreygolnik(a, b, c, h);
                     Treygolnik treygol = new Treygolnik(a, b, c);
                     Console.Clear();

                     treygol.vid(a, b, c);
                     pirotreygolnik.Out();

                 }
                     break;
             }
         }
             break;
     }
 }


        


    
    
        
    

