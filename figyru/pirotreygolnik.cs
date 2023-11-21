using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treygol;

namespace figyru
{
    class pirotreygolnik : Treygolnik
    {
        private double a;
        private double b;
        private double c;
        private double h;

        public pirotreygolnik(double a, double b, double c, double h) : base(a, b, c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }
    
        private double surfacearea()
        {
            double p = peri() / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // площадь боковой поверхности треугольника
            return (1.0 / 2) * peri() * h + s; // площадь основания + площадь боковой поверхности
        }

        private double volume()
        {
            return (1.0 / 3) * area() * h;
        }

        public override void Out()
        {
            base.Out();
            Console.WriteLine($"Площадь всей поверхности пирамиды равна {surfacearea():f2}");
            Console.WriteLine($"Объем пирамиды равен {volume():f2}");

        }
    }
}
