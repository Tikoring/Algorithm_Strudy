using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class PaintOver
    {
        public int Solution(int n, int m, int[] section) 
        {
            int answer = 0;
            int idx = 0;
            int before = section[idx];
            bool[] painting = new bool[section.Length];
            for (int i = 0; i < painting.Length; i++)
                painting[i] = false;
            
            for (int i = 1; i < section.Length; i++)
            {
                if (section[i] - before + 1 < m) continue;
                else if (section[i] - before + 1 == m)
                {
                    answer += 1;
                    for (int j = idx; j <= i; j++)
                        painting[j] = true;
                    if (i + 1 != section.Length) {
                        before = section[i + 1];
                        idx = i + 1;
                    }
                }
                else
                {
                    before = section[i];
                    answer += 1;
                    for (int j = idx; j < i; j++)
                        painting[j] = true;
                    idx = i;
                }
            }
            if (!painting[idx]) answer += 1;
            
            return answer;
        }
    }
}