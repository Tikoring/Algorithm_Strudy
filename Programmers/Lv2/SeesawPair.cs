using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class SeesawPair
    {
        public long Solution(int[] weights) 
        {
            long answer = 0;
            Dictionary<int, int> weighting = new Dictionary<int, int> ();
            Array.Sort (weights);
            for (int i = 0; i < weights.Length; i++)
            {
                if (weighting.ContainsKey (weights[i])) weighting[weights[i]]++;
                else weighting.Add (weights[i], 1);
            }

            for (int i = 0; i < weights.Length; i++)
            {
                int w = weights[i];
                int n = 0;
                if (weighting.TryGetValue (w * 2, out n)) answer += n;
                if (w % 2 == 0)
                {
                    if (weighting.TryGetValue (w * 3 / 2, out n)) answer += n;
                }
                if (w % 3 == 0)
                {
                    if (weighting.TryGetValue (w * 4 / 3, out n)) answer += n;
                }
            }
            foreach (int w in weighting.Keys.ToArray ())
            {
                answer += (long) weighting[w] * (weighting[w] - 1) / 2;
            }

            return answer;
            
        }
    }
}