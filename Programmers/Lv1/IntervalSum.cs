using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class IntervalSum
    {
        public long Solution(int a, int b) 
        {
            long answer = 0;
            int[] nums = new int[2];
            nums[0] = Math.Min (a, b);
            nums[1] = Math.Max (a, b);
            for (int i = a; i <= b; i++)
                answer += i;
            return answer;
        }
    }
}