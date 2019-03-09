using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
            Console.Write(" " + i);
                i += 2;
            }

            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);

            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }


            Console.WriteLine(" ");
            double x, x1, x2,y;
            Console.WriteLine("x1 = ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("x2 = ");
            x2 = int.Parse(Console.ReadLine());
            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("x = {0}  sinx= {1}",x,y);
                x = x + 0.01;
            }
            while (x <= x2);

            int a, b, temp;
            Console.WriteLine("a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("Ans = {0}",temp);


            Console.WriteLine("x1 = ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("x2 = ");
            x2 = int.Parse(Console.ReadLine());
            x = x1;
            while (x < x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("x = {0}  sinx= {1}", x, y);
                x = x + 0.01;
            }


            Console.WriteLine("a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            do
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            } while (temp != b) ;
                Console.WriteLine("Ans = {0}", temp);


            System.Threading.Thread.Sleep(2000);
        }
    }
}
