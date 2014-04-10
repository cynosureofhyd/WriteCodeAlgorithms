using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrustratedAlgorithms.Arrays
{
    public class FindKthLargestInArray
    {
        public static int Find(List<int> array, int k)
        {
            if (array.Count() == 0)
                return -100;
            else
            {
                Random rand = new Random();
                int pivot = rand.Next(0, array.Count() - 1);
                return FindKth(array, 0, array.Count() - 1, pivot, k);
            }
        }

        private static int FindKth(List<int> array, int start, int end, int pivot, int k)
        {
            int left = start;
            int right = end;
            while(left <= right)
            {
                while (left <= right && array[left] <= array[pivot])
                    ++left;
                while (left <= right && array[right] >= array[pivot])
                    --right;
                if (left <= right)
                    swap(array, left, right);
            }

            return -1;
        }

        private static void swap(List<int> array, int left, int right)
        {
            if (array.Count() <= 0)
                return;
            else
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }
    }
}
