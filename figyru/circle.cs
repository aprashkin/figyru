﻿using figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    internal class Circle
    {
        protected double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public void Perimetr(double r)
        { 
            this.r = r;
            double p = 2 * Math.PI * r;
            Console.WriteLine($"Радиус круга равен {r}, периметр равен {p}");
        }
        double s;
        public void Ploshad(double r)
        {
            this.r = r;
            double s = Math.PI * Math.Pow(r, 2); 
            
        }
        public void Out()
        { Console.WriteLine($"площадь круга равна {s}, периметр равен {p}" );
    }
}

//люблю шарпы как друга. как тверь любила мишу круга