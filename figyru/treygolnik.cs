using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treygol
{
    class Treygolnik
    {
        protected double a;
        protected double b;
        protected double c;

        public Treygolnik (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double peri()
        {
            return (a + b + c);
        }

        public double area()
        {
            double we = (a + b + c) / 2;
            return Math.Sqrt(we * (we - a) * (we - b) * (we - c));       
        }
        
        public virtual void Out()
        {
            Console.WriteLine($"Периметр треугольника равен: {peri():f2}");
            Console.WriteLine($"Площадь треугольника равна: {area():f2}");
        }
        
        public void vid(double a, double b, double c)
    {
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

      