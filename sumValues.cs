using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace DSAWorkshop
{
    public static class SumValues
    {
        //Calculate the sum of all natural numbers from 1 up to n.
        public static int AddUpTo(int n)
        {
            int total = 0;
            for (int i = 0; i <= n; i++)
            {
                total += i;
            }

            return total;
        }

        public static int AddUpToOptimised(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}