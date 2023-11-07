using figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    internal class pirocircle : Circle
    {

        private double h;

        public pirocircle (double r) : base(r)
        {
            this.h = h;
            this.r = r;
        }
        private double total_area()
        {
            double l = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(h, 2));
            double x = Math.PI * r * l;
            return Ploshad() + x;
        }
    }
}
