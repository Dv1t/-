using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int i,s = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }
            Console.Write("sum = {0}",s);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
