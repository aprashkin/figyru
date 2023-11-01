using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treygol
{
    internal class Treygolnik
    {
        private double a;
        private double b;
        private double c;

        public void Perimetr(double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            double p;
            p = a + b + c;
            Console.WriteLine($"Для данного треугольника со сторонами {a} {b} {c} периметр равен {p}");

        }

        public void Ploshad(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            double s;

            double pp = (a + b + c) / 2;

            s = (double)Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
            Console.WriteLine($"Для данного треугольника со сторонами {a} {b} {c} площадь равна {s}");

        }
        
        public void vid(double a, double b, double c)
    {
      this.a = a;
      this.b = b;
      this.c = c;

      if (a == b && b == c)
      {
        Console.Write("Треугольник равноcторонний");
      }
      

        else if ((Math.Pow(a, 2) == (c * c) + (b * b)) || ((Math.Pow(b, 2) == (c * c) + (a * a)) || ((Math.Pow(c, 2) == (a * a) + (b * b)))))
        {
          Console.WriteLine("Треугольник прямоугольный");
        }

          else if (a == b || a == c || b == c) 
          {
            Console.WriteLine("Треугольник равнобедренный");
          }

      else
      {
        Console.WriteLine("Треугольник остроугольный");
      }

    }



    }
}
