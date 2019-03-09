using System;
class DevideIt
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter the first integer");
            string temp = Console.ReadLine();
            int i = Int32.Parse(temp);
            Console.WriteLine("Please enter the second integer");
            temp = Console.ReadLine();
            int j = Int32.Parse(temp);
            int k = i / j;
            Console.WriteLine(k);
            System.Threading.Thread.Sleep(2000);
        }
        catch (FormatException e)
        {
            Console.WriteLine("An format exception was trown: {0}", e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("An DivideByZero exception was trown: {0}", e.Message);
            System.Threading.Thread.Sleep(2000);
        }
        catch (Exception e)
        {
            Console.WriteLine("An exception was trown: {0}", e.Message);
        }

    }
}

