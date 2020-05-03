using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmics.Codility
{
    public static class TapeEquilibrium
    {
        public static int Solution(int[] a)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var seriePosAsc = new Dictionary<int, int>();
            var seriePosDes = new Dictionary<int, int>();

            int sumAsc = 0, sumDes = 0, min = -1;

            for (int i = 0; i < a.Length; i++)
            {
                sumAsc += a[i];
                seriePosAsc.Add(i, sumAsc);

                sumDes += a[a.Length - 1 - i];
                seriePosDes.Add(a.Length - 1 - i, sumDes);
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                int x = seriePosAsc[i] - seriePosDes[i + 1];
                int p = Math.Abs(x);

                if (min == -1)
                {
                    min = p;
                }
                else
                {
                    if (p < min)
                    {
                        min = p;
                    }
                }
            }

            return min;
        }
    }
}
