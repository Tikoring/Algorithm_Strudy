using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class NextNum
    {
        public int Solution(int[] common)
        {
            int answer = 0;
            int[] d1 = {0, 0};
            int[] d2 = {0, 0};
            for (int i = 0; i < 2; i++)
            {
                d1[i] = common[i + 1] - common[i];
                if (common[i] == 0) continue;
                d2[i] = common[i + 1] / common[i];
            }
            if (d1[0] == d1[1])
            {
                answer = common.Last () + d1[0];
            } else 
            {
                answer = common.Last () * d2[0];
            }
            return answer;
        }
    }
}