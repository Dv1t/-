using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            Book.SetPrice(12);
            b1.Print();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b1.PriceBook(3));
            Book.SetPrice(5);
            b1.Print();

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 
                1234, 2013);
            b2.Print();

            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            b3.Print();
           
            Triangle t1 = new Triangle(1, 1, 100);
            t1.Print();
            t1.Perimetr();
            t1.Square();

            Console.ReadKey();
        }
    }
}
