using figures;
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

        protected double perimeter()
        { return (2 * 3.14 * r); }

        public virtual double area()
        { return (r * r) * 3.14; }
       

        public virtual void Out()
        {
            Console.WriteLine($"Площадь круга с радиусом {r} равна {area():f3}; периметр равен {perimeter():f3}");
        }
    }
}

//люблю шарпы как друга. как тверь любила мишу круга