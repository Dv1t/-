using System;
namespace _5
{
    class MatrixMultiply
    {
        static void Main(string[] args)
        {
            int[] a;
            Console.Write("Введите размер массива: ");
            int n = int.Parse(System.Console.ReadLine());
            a = new int[n];
            for(int i =0;i<n;i++)
            {
                Console.Write("Введите {0}-й элемент массива: ",i+1);
                a[i] = int.Parse(System.Console.ReadLine());
            }
            int s=0,so=0,sp=0,sc=0,sn=0,max=-9999999,min=9999999,smin=0,imin=0,imax=0;
           for(int i=0;i<n;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                    imax = i;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
                s += a[i];
                if(a[i]<0)
                {
                    so += a[i];
                }
                else
                {
                    sp += a[i];
                }
                if((i+1)%2==0)
                {
                    sc += a[i];
                }
                else
                {
                    sn += a[i];
                }
                
            }
           if(imin>imax)
            {
                for(int i = imax;i<=imin;i++)
                {
                    smin += a[i];
                }
            }
           else
            {
                for (int i = imin; i <= imax; i++)
                {
                    smin += a[i];
                }
            }
            float sr = (float)s / n;
            Console.WriteLine("Сумма всех элементов массива = {0}", s);
            Console.WriteLine("Сумма отрицательных элементов массива = {0}", so);
            Console.WriteLine("Сумма положительных элементов массива = {0}", sp);
            Console.WriteLine("Сумма элементов массива с чётными номерами = {0}", sc);
            Console.WriteLine("Сумма элементов массива с нечётными номерами = {0}", sn);
            Console.WriteLine("Среднее значение элементов массива = {0}", sr);
            Console.WriteLine("Максимальное значение элементов массива = {0}", max);
            Console.WriteLine("Сумма значений элементов массива между максимальеым и минимальным = {0}", smin);
            Console.ReadKey();
        }
    }
}
