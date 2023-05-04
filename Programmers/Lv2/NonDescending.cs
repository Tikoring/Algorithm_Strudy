using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class NonDescending
    {
        public int[] Solution(int[] sequence, int k) 
        {
            int[] answer = new int[2] {0, sequence.Length};
            int start = 0;
            int sum = 0;
            for (int i = start; i < sequence.Length; i++)
            {
                sum += sequence[i];
                if (sum == k)
                {
                    if (i - start + 1 < answer[1] - answer[0] + 1)
                    {
                        answer[0] = start;
                        answer[1] = i;
                    }
                    else if (i - start + 1 == answer[1] - answer[0] + 1 && start < answer[0])
                    {
                        answer[0] = start;
                        answer[1] = i;
                    }
                    start += 1;
                    i = start - 1;
                    sum = 0;
                }
                else if (sum > k)
                {
                    sum -= sequence[start] + sequence[i];
                    start += 1;
                    i -= 1;
                }
            }
            return answer;
        }
    }
}