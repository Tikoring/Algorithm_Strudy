using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class SinglePlay
    {
        public int Solution(int[] cards) 
        {
            int answer = 0;
            bool[] visit = new bool[cards.Length];
            List<int> sum = new List<int> ();
            for (int i = 0; i < cards.Length; i++)
            {
                int s = 0;
                int next = i;
                bool cycle = false;
                while (!visit[next])
                {
                    s++;
                    visit[next] = true;
                    next = cards[next] - 1;
                    cycle = true;
                }
                if (cycle)
                {
                    sum.Add (s);
                }
            }
            
            sum.Sort ((a, b) => {return b.CompareTo (a);});
            if (sum.Count > 1)
            {
                answer = sum[0] * sum[1];
            }
            else
            {
                answer = 0;
            }
            return answer;
        }
    }
}