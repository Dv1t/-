using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Operation
    {
        private static bool CheckT(int a, int b, int c)
        {
            if (a + b < c)
            {
                return false;
            }
            if (a + c < b)
            {
                return false;
            }
            if (b + c < a)
            {
                return false;
            }
            return true;
        }

        public static double GetS(int a, int b,int c)
        {
            if (CheckT(a, b, c))
                {
                float p = (a + b + c) / 2;
                double s = p * (p - a) * (p - a) * (p - a);
                s = Math.Sqrt(s);
                return s;
                }
            else
            {
                return 0;
            }
           
        }
 
        public static double GetS(int a)
        {
            float p = (a * 3) / 2;
            double s = p * (p - a) * (p - a) * (p - a);
            s = Math.Sqrt(s);
            return s;
        }

        public static int Roots(int a,int b,int c, ref float x1,ref float x2)
        {
            float d = b * b - 4 * a * c;
            if(d<0)
            {
                return -1;
            }
            if(d==0)
            {
                x1 =(float) (b * -1) / (2 * a);
                return 0;
            }
            if(d>0)
            {
                x1 = (float)((b * -1)+Math.Sqrt(d)) / (2 * a);
                x2 = (float)((b * -1) - Math.Sqrt(d)) / (2 * a);
                return 1;
            }
            return -1;
        }
    }
}
