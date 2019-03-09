using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            bool ok;
            Console.WriteLine("Number for factorial:");
            int x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");

            Console.WriteLine("Введите первую сторону:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь треугольник равна:{0}",Operation.GetS(a,b,c));

            Console.WriteLine("Введите сторону:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь треугольник равна:{0}", Operation.GetS(a));

            Console.WriteLine("Введите коэффициенты:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            float x1=0, x2=0;
            int result =  Operation.Roots(a, b, c,ref x1, ref x2);
            if( result==-1)
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.",a,b,c);
            }
            if(result==0)
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны один x1= x2 = {3}.", a, b, c,x1);
            }
            if (result == 1)
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = {2}, x2 = {3}.", a, b, c, x1,x2);
            }
            System.Threading.Thread.Sleep(2000);
        }
    }
}
