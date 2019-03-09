using System;
namespace _8tvor
{ 
    class ArithmeticProgression:Progression
    {
        int[] m;

        public ArithmeticProgression(int n,int p,int s)
        {

            m = new int[n];
            int temp = s;
            for (int i =0;i<n;i++)
            {
                m[i] = temp;
                temp += p;
            }
        }

        public int GetElement(int k)
        {
            return m[k];
        }
    }
}
