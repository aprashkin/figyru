using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class square_pyramid : Square
    {
        private double h;


        public square_pyramid(double a, double h) : base(a)
        {
            this.h = h;
        }

        private double total_surface_area()
        {
            double x = Math.Sqrt((a / 2) * (a / 2) + h * h); //нак ребро

            return area() + 4 * (0.5 * a * x); // площадь основания и боковой
        }

        private double volume()
        {
            return (1.0 / 3) * area() * h;
        }

        public new void Out()
        {
            Console.WriteLine("Для пирамиды с основанием квадратик имеющим стороны " + a);
            Console.WriteLine($"Площадь поверхности пирамиды: {total_surface_area():f3}");
            Console.WriteLine($"Периметр основания пирамиды {perimeter():f3}");
            Console.WriteLine($"Объем пирамиды: {volume():f3}");
        }
    }
}