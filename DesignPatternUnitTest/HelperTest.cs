using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternUnitTest
{
    internal static class HelperTest
    {
        internal static bool AreEquals(IEnumerable<string> a, IEnumerable<string> b, bool order = false)
        {
            if (a.Count() != b.Count()) return false;

            if(order)
            {
                for (int i = 0; i < a.Count(); i++)
                    if (a.ElementAt(i) != b.ElementAt(i)) return false;

                return true;
            }
            else
            {
                a = a.OrderBy(q => q);
                b = b.OrderBy(q => q);

                for (int i = 0; i < a.Count(); i++)
                    if (a.ElementAt(i) != b.ElementAt(i)) return false;

                return true;
            }
        }
    }
}
