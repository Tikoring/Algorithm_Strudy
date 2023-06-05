using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class MandarinChoice
    {
        public int Solution(int k, int[] tangerine) 
        {
            int answer = 0;
            int[] counter = new int[10000001];
            int n = 100000;
            for (int i = 0; i < tangerine.Length; i++)
            {
                counter[tangerine[i]]++;
            }

            Array.Sort (counter, (int a, int b) => {return b.CompareTo (a);});
            DFS (ref n, counter, 0, 0, k, 0);
            
            return answer = n;
        }

        private void DFS (ref int pair, int[] count, int sizes, int sum, int total, int idx)
        {
            if (sum < total && idx < count.Length)
            {
                sizes += 1;
                for (int i = idx; i < count.Length && count[i] > 0 && count.Length - i > pair; i++)
                {
                    DFS (ref pair, count, sizes, sum + count[i], total, i + 1);
                }
            }
            else 
            {
                if (sizes < pair)
                {
                    pair = sizes;
                }
            }
        }
    }
}