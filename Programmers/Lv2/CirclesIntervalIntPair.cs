using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class CirclesIntervalIntPair
    {
        public long Solution(int r1, int r2) 
        {
            long answer = 0;
            for (int i = -r2; i < r2; i++)
            {
                for (int j = -r2; j < r2; j++)
                {
                    long l = i * i + j * j;
                    if (l >= r1 * r1 && l <= r2 * r2) answer++;
                }
            }
            return answer;
        }
    }
}