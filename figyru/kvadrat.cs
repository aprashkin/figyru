﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    internal class Square
    {

        protected double a;

        public Square(double a)
        {
            this.a = a;
        }

        protected double perimeter()
        {
            return (4 * a);
        }

        protected double area()
        {
            return (a * a);
        }

        public void Out()
        {
            Console.WriteLine($"Квадрат со сторонами {a}");
            Console.WriteLine($"Площадь квадрата: {area():f3}");
            Console.WriteLine($"Периметр квадрата: {perimeter():f3}");
        }


    }
}