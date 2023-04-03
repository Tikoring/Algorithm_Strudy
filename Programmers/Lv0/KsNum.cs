using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class KsNum
    {
        public int Solution(int i, int j, int k)
        {
            int answer = 0;
            for (int s = i; s <= j; s++)
            {
                int n = s;
                while (n > 0)
                {
                    if (n % 10 == k) answer++;
                    n /= 10;
                }
            }
            return answer;
        }
    }
}