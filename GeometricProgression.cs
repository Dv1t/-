using System;

namespace _7
{
    class GeometricProgression:Progression
    {
        int[] m;

        public GeometricProgression(int n, int p, int s)
        {

            m = new int[n];
            int temp = s;
            for (int i = 0; i < n; i++)
            {
                m[i] = temp;
                temp *= p;
            }
        }

        public override int GetElement(int k)
        {
            return m[k];
        }
    }
}
