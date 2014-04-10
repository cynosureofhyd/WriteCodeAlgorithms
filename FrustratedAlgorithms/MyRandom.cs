using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrustratedAlgorithms
{
    public class MyRandom
    {
        public static List<int> Random(int size)
        {
            List<int> result = new List<int>();
            Random rand = new Random();
            for(int i= 0; i < size; i++)
            {
                result.Add(rand.Next());
            }
            return result;
        }

        public static List<int> Random(int size, int maxValue)
        {
            List<int> result = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                result.Add(rand.Next(maxValue));
            }
            return result;
        }
    }
}
