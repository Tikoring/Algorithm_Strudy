using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class AliquotAddSubtraction
    {
        public int Solution(int left, int right) 
        {
            int answer = 0;
            for (int i = left; i <= right; i++)
            {
                int n = (int) Math.Sqrt (i);
                if (n * n == i) answer -= i;
                else answer += i;
            }
            return answer;
        }
    }
}