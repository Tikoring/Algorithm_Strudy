using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class GymCloth
    {
        public int Solution(int n, int[] lost, int[] reserve) 
        {
            int answer = 0;
            int[] own = new int[n];
            for (int i = 0; i < n; i++)
                own[i] = 1;
            for (int i = 0; i < lost.Length; i++)
                own[lost[i] - 1] -= 1;
            for (int i = 0; i < reserve.Length; i++)
                own[reserve[i] - 1] += 1;

            for (int i = 0; i < n; i++)
            {
                if (own[i] == 0)
                {
                    if (i - 1 >= 0 && own[i - 1] == 2)
                    {
                        answer++;
                        own[i - 1] = 1;
                    }
                    else if (i + 1 < n && own[i + 1] == 2)
                    {
                        answer++;
                        own[i + 1] = 1;
                    }
                }
                else
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}