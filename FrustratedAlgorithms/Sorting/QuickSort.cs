using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrustratedAlgorithms.Sorting
{
    public class QuickSort
    {
        public static void Sort(List<int> array)
        {
            int[] arrayint = Quicksort(array.ToArray(), 0, array.Count() - 1);
            array.Clear();
            array.AddRange(arrayint);
            //Sort(array, 0, array.Count() - 1);
        }

        private static void Sort(List<int> array, int left, int right)
        {
            int pivot = Partition(array, left, right);
            Sort(array, left, pivot - 1);
            Sort(array, pivot + 1, right);
        }

        private static int Partition(List<int> array, int start, int last)
        {
            int left = start;
            int right = last;
            int randomPivot = (left + right)/2;
            while(left <= right)
            {
                while (array[left] < array[randomPivot])
                    left++;
                if (left == last) break;
                while (array[right] > array[randomPivot])
                    right--;
                if (right == start) break;
                if (left <= right)
                {
                    swap(array, left, right);            
                }
                if (left >= right)
                    break;
            }
            return randomPivot;
            //return -100;
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


        private static int[] Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

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
                    int tmp = elements[i];
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
            return elements;
        }
    }
}
