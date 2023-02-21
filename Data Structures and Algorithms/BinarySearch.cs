using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal static class BinarySearch
    {
        public static int Search(int target, int[] arr)
        {
            int bottom = 0;
            int top = arr.Length-1;
            int mid;

            while (bottom <= top)
            {
                mid = bottom + (top - bottom) / 2;
                if (target < arr[mid])
                {
                    top = mid-1;
                }
                else if(target > arr[mid])
                {
                    bottom = mid+1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        } 
    }
}
