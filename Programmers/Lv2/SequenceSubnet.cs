using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class SequenceSubnet
    {
        public int Solution(int[] elements) 
        {
            int answer = 0;
            List<int> subnetE = new List<int> (elements);
            HashSet<int> sums = new HashSet<int> (elements);
            for (int i = 0; i < elements.Length - 1; i++)
            {
                subnetE.Add (elements[i]);
                for (int j = 0; j < subnetE.Count - (i + 1); j++)
                {
                    int n = 0;
                    for (int k = 0; k <= (i + 1); k++)
                    {
                        n += subnetE[j + k];
                    }
                    sums.Add (n);
                }
            }
            answer = sums.Count;
            return answer;
        }
    }
}