using figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class pirocircle : Circle
    {

     private double h;

        public pirocircle(double r, double h) : base(r)
        {
            this.h = h;
        }

        private double total_area()
        {
            double l = Math.Sqrt( Math.Pow ( r, 2 ) + Math.Pow ( h, 2 ) );
            double x = Math.PI * r * l;

            return area() + x;
        }

        private double volume() 
        {
            return (1.0 / 3) * area() * h;
        }

        public override void Out()
        {
            base.Out();
            Console.WriteLine($"Площадь конуса равна {total_area():f3}, объём равен {volume():f3}") ;
        }
    }
}
