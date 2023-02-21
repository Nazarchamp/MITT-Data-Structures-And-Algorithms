using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal static class FibonacciWithCaching
    {
        private static Dictionary<int, ulong> fibonacciCache = new Dictionary<int, ulong>() { { 0, 0 }, { 1, 1 } };

        public static ulong CachedFibonacci(int fibonacciIndex)
        {
            if (fibonacciCache.ContainsKey(fibonacciIndex))
            {
                return fibonacciCache[fibonacciIndex];
            }
            fibonacciCache[fibonacciIndex] = CachedFibonacci(fibonacciIndex - 1) + CachedFibonacci(fibonacciIndex - 2);
            return fibonacciCache[fibonacciIndex];
        }
    }
}
