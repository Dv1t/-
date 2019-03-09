using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Item item1 = new Item();
            //item1.Print();
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234,
new DateTime(2014, 12, 14));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Print();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.TakeItem();
            mag1.Print();

            Console.WriteLine("\n Тестирование полиморфизма");
            b2.ReturnSrok();
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Print();
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Print();

            int n = 5;
            int p = 3;
            int s = 1;

            ArithmeticProgression a1 = new ArithmeticProgression(n, p, s);
            GeometricProgression g1 = new GeometricProgression(n, p, s);

            for(int i = 0;i<n;i++)
            {
                Console.Write(" {0}",a1.GetElement(i));

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0}", g1.GetElement(i));

            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
