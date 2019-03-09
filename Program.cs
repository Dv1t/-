using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
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

            Audit.RunAudit();
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.TakeItem();
            mag1.Print();
            mag1.Subs();
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

            Book b1 = new Book("Толстой Л.Н.", "Война и мир 2", publ, 1235, 2013, 100, true);
            Book b3 = new Book("Толстой Л.Н.", "Война и мир 3", publ, 1236, 2013, 99, true);
            Magazine mag2 = new Magazine("О технике", 5, "Земля и мы", 2014, 1237, true);

            Audit.StopAudit();
            mag2.Subs();

            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b1, b2, b3, mag1, mag2 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру"); foreach (Item x in itlist) { x.Print(); }

            Console.ReadKey();
        }
    }
}
