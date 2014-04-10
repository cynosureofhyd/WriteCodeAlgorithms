using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrustratedAlgorithms.Arrays;
using FrustratedAlgorithms.Sorting;

namespace FrustratedAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort.Sort(MyRandom.Random(10, 100));
            int result = FindKthLargestInArray.Find(MyRandom.Random(10, 100), 10);

            // Create an unsorted array of string elements
            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };
            
            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
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
