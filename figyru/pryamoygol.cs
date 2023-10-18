using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryamoygol
{
    internal class Rectangle
    {
        private float a;
        private float b;


        public void Perimetr(float a, float b)
        {
            this.a = a;
            this.b = b;
            float p = (a + b) * 2;
            Console.WriteLine($"Для прямоугольника со сторонами {a} и {b} периметр равен {p}"); ;
        }
        public void Ploshad(float a, float b)
        {
            this.a = a;
            this.b = b;
            float s = a * b;
            Console.WriteLine($"Для прямоугольника со сторонами {a} и {b} площадь равна {s}");
        }





    }
}