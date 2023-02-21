using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal static class Factorial
    {
        public static ulong FactorialOf(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return FactorialOf(n - 1) * n;
            }
        }
    }
}
