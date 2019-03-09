using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Triangle
    {
        public int a, b, c;
        private bool exist=true;
        public Triangle(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if((a+b<c)||(a+c<b)||(b+c<a))
            {
                Console.WriteLine("Треугольник с заданными параметрами не существует");
                exist = false;
            }
        }
        public void Print()
        {
            if (exist)
            {
                Console.WriteLine("Длины сторон:{0},{1},{2}", this.a, this.b, this.c);
            }
            else
            {
                Console.WriteLine("Треугольник с заданными параметрами не существует");
            }
        }
        public void Perimetr()
        {
            if (exist)
            {
                Console.WriteLine("Периметр = {0}", this.a+ this.b+ this.c);
            }
            else
            {
                Console.WriteLine("Треугольник с заданными параметрами не существует");
            }
        }
        public void Square()
        {
            if (exist)
            {
                float p = (float)(this.a + this.b + this.c) / 2;
            double s = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
            Console.WriteLine("Площадь = {0}", s);
            }
            else
            {
                Console.WriteLine("Треугольник с заданными параметрами не существует");
            }
        }

    }
}
