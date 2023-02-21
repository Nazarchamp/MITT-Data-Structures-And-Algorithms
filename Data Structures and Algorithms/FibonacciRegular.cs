using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal static class FibonacciRegular
    {
        public static ulong Fibonacci(int fibonacciIndex)
        {
            if(fibonacciIndex == 0)
            {
                return 0;
            }
            else if(fibonacciIndex == 1) 
            { 
                return 1;
            }
            return Fibonacci(fibonacciIndex-1) + Fibonacci(fibonacciIndex - 2);
        }
    }
}
