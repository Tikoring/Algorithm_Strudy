using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class NearNum
    {
        public int Solution(int[] array, int n)
        {
            int answer = 0;
            Array.Sort (array);
            int diff = Int32.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (diff > Math.Abs (n - array[i]) )
                {
                    answer = array[i];
                    diff = Math.Abs (n - array[i]);
                }
            }
            return answer;
        }
    }
}