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



    }
}
