using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s=0;
            float x, y;
            Random rnd = new Random();
            int r = rnd.Next();
            float[] xm= new float[3], ym = new float[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("x=");
                x = float.Parse(Console.ReadLine())+(r/2);
                xm[i] = x;
                Console.Write("y=");
                y = float.Parse(Console.ReadLine()) + (r / 2);
                ym[i] = y;
                if (x * x + y * y <= 1+r)
                {
                    s += 10;
                    Console.WriteLine("+10");
                }
                else if (x * x + y * y <= 4+r)
                {
                    s += 5;
                    Console.WriteLine("+5");
                }
                else if (x * x + y * y <=9+r)
                {
                    s += 1;
                    Console.WriteLine("+1");
                }
                else
                {
                    Console.WriteLine("Мимо");
                }
            }
            Console.WriteLine("Sum = {0}",s);
            Console.ReadKey();
        }
    }
}
