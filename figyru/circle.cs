using Circles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    internal class Circle
    {
        protected float r;
        public void Perimetr(float r)
        {
            this.r += r;
            double p = 2 * Math.PI * r;
            Console.WriteLine($"Радиус круга равен {r}, периметр равен {p}");
        }

        public void Ploshad(float r)
        {
            this.r += r;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Радиус круга равен {r}, площадь равна {s}");
        }  
    }
}

//люблю шарпы как друга. как тверь любила мишу круга