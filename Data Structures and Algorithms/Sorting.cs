using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal static class Sorting
    {
        public static int[] SelectionSort(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                int min = arr[i];
                int minIndex = i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[j] < min) 
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }
                arr[minIndex] = arr[i];
                arr[i] = min;
            }
            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i] < arr[i - 1])
                {
                    for(int j=i; j>0; j--)
                    {
                        if(arr[j-1] > arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j-1] = temp;
                        }
                        else
                            break;
                    }
                }
            }
            return arr;
        }
    }
}
