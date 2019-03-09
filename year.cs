using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Year = ");
            int y = int.Parse(Console.ReadLine());
            if(((y%4==0)&(y%100!=0))||(y%400==0))
            {
                Console.Write("Високосный");
            }
            else
            {
                Console.Write("Не високосный");
            }
            System.Threading.Thread.Sleep(2000);
        }
    }
}
