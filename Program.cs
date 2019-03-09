using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8tvor
{
    class Program
    {
        static void Main(string[] args)
        {

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
