using System;
    public enum AccountType { Checking, Deposit}
    public struct Distance
    {
    public long feet;
    public long inch;
    }
    class Program
    {
        static void Main(string[] args)
        {
        Distance d1, d2, d3;
        Console.WriteLine("Enter feets: ");
        d1.feet = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter inchs: ");
        d1.inch = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter feets: ");
        d2.feet = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter inchs: ");
        d2.inch = long.Parse(Console.ReadLine());

        d3.feet = d1.feet + d2.feet;
        d3.inch = d1.inch + d2.inch;
        if(d3.inch>12)
        {
            d3.inch -= 12;
            d3.feet++;
        }
        Console.WriteLine("Distance 1 = {0} '-{1}\"",d1.feet,d1.inch);
        Console.WriteLine("Distance 2 = {0} '-{1}\"", d2.feet, d2.inch);
        Console.WriteLine("Distance 3 = {0} '-{1}\"", d3.feet, d3.inch);
        Console.ReadKey();
    }
    }

