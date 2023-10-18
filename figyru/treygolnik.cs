using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treygol
{
    internal class Treygolnik
    {
        private float a;
        private float b;
        private float c;

        public void Perimetr(float a, float b, float c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            float p;
            p = a + b + c;
            Console.WriteLine($"Для данного треугольника со сторонами {a} {b} {c} периметр равен {p}");

        }

        public void Ploshad(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            float s;

            float pp = (a + b + c) / 2;

            s = (float)Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
            Console.WriteLine($"Для данного треугольника со сторонами {a} {b} {c} площадь равна {s}");

        }
        
        public void vid(float a, float b, float c)
    {
      this.a = a;
      this.b = b;
      this.c = c;

      if (a == b || a == c || b == c)
      {
        Console.Write("Треугольник равнобедренный");
      }
      

        else if ((Math.Pow(a, 2) == (c * c) + (b * b)) || ((Math.Pow(b, 2) == (c * c) + (a * a)) || ((Math.Pow(c, 2) == (a * a) + (b * b)))))
        {
          Console.WriteLine("Треугольник прямоугольный");
        }

          else if (a == b && b == c) 
          {
            Console.WriteLine("Треугольник равносторонний");
          }

      else
      {
        Console.WriteLine("Треугольник остроугольный");
      }

    }



    }
}
