using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadrat
{
    internal class Square
    {
        private float g;

        public void Perimetr(float g)
        {
            this.g = g;
            float p = g * 4;

            Console.WriteLine($"Периметр квадрата со стороной {g} = {p}");
        }
        public void Ploshad(float g)
        {
            this.g = g;

            float s = g * g;
            Console.WriteLine($"Площадь квадрата со стороной {g} = {s}");
        }




    }