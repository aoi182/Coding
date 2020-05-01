using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicsUnitTest
{
    public static class HelperTest
    {
        public static bool AreEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length) return false;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] != b[i]) return false;
                }
            }

            return true;
        }
    }
}
