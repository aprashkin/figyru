using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace figures
{
    internal class RectPiramida : Rectangle
    {
        private double h;

        public RectPiramida(double a, double b, double h) : base(a, b)
        {
            this.h = h;
        }
        private double total_surface_area()
        {
            double x = a * Math.Sqrt(Math.Pow(b / 2, 2) + Math.Pow(h, 2)) + b * Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));

            return area() + x; ;
        }

        private double volume()
        {
            return (1.0 / 3) * area() * h;
        }

        public override void Out()
        {
            Console.WriteLine($"Прямоугольник со сторонами {a} и {b}");
            Console.WriteLine($"Полная площадь поверхности пирамиды: {total_surface_area():f3}");
            Console.WriteLine($"Периметр основания пирамиды: {peri():f3}");
            Console.WriteLine($"Объем пирамиды: {volume():f3}");
        }






    }
}