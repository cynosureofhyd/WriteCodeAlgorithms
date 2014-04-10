using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrustratedAlgorithms.Arrays;
using FrustratedAlgorithms.Sorting;
using System.Diagnostics;

namespace FrustratedAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10000000;
            
            for (int i = 10; i < size; )
            {
                // Create new stopwatch
                Stopwatch stopwatch = new Stopwatch();
                // Begin timing
            
                stopwatch.Start();

                List<int> input = MyRandom.Random(i, i);
                QuickSort.Sort(input);
                // Stop timing
                stopwatch.Stop();

                // Write result
                Console.WriteLine(" for input: {0} Time elapsed : {1}", i,
                    stopwatch.Elapsed);

                i = i * 10;
            }
            
            //int result = FindKthLargestInArray.Find(MyRandom.Random(10, 100), 10);
            
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void sortstrings()
        {
            // Create an unsorted array of string elements
            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);
        }


        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
