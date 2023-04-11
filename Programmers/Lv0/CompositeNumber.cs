using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class CompositeNumber
    {
        public int Solution(int n) 
        {
            int answer = 0;
            for (int i = 2; i <= n; i++)
            {
                int count = 0;
                for (int j = 1; j <= Math.Sqrt (i); j++)
                {
                    if (i % j == 0) count++;
                    Console.WriteLine (i);
                }
                if (count > 1) answer++;
            }
            return answer;
        }
    }
}