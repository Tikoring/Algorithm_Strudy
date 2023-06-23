using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class ArraySplit
    {
        public int[] Solution(int n, long left, long right) 
        {
            int[] answer = new int[right - left + 1];
            for (long i = left; i <= right; i++)
            {
                int d = (int) (i / n);
                int r = (int) (i % n);
                if (d > r)
                {
                    answer[i - left] = d + 1;
                }
                else
                {
                    answer[i - left] = r + 1;
                }
            }
            return answer;
        }
    }
}