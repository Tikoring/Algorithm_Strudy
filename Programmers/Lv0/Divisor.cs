using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Divisor
    {
        public int[] Solution(int n)
        {
            int[] answer = new int[] {};
            int max = (int) Math.Sqrt (n);
            int idx = 0;
            for (int i = 1; i <= max; i++) {
                if (n % i == 0)
                {
                    if (i * i == n) 
                    {
                        Array.Resize (ref answer, idx + 1);
                        answer[idx++] = i;
                    }
                    else 
                    {
                        Array.Resize (ref answer, idx + 2);
                        answer[idx++] = i;
                        answer[idx++] = n / i;
                    }
                }
            }
            Array.Sort (answer);
            return answer;
        }
    }
}