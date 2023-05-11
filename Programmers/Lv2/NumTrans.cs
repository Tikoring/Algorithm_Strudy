using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class NumTrans
    {
        public int Solution(int x, int y, int n) 
        {
            int answer = 0;
            int[] count = new int[1000001];
            Array.Fill (count, -1);
            count[x] = 0;
            for (int i = x; i < y; i++)
            {
                if (count[i] == -1) continue;
                else
                {
                    if (i + n <= y)
                    {
                        if (count[i + n] == -1) count[i + n] = count[i] + 1;
                        else count[i + n] = Math.Min (count[i + n], count[i] + 1);
                    }
                    if (i * 2 <= y)
                    {
                        if (count[i * 2] == -1) count[i * 2] = count[i] + 1;
                        else count[i * 2] = Math.Min (count[i * 2], count[i] + 1);
                    }
                    if (i * 3 <= y)
                    {
                        if (count[i * 3] == -1) count[i * 3] = count[i] + 1;
                        else count[i * 3] = Math.Min (count[i * 3], count[i] + 1);
                    }
                }
            }
            answer = count[y];
            return answer;
        }
    }
}