using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Factorization
    {
        public int[] Solution(int n) 
        {
            int[] answer = new int[] {};
            HashSet<int> set = new HashSet<int> ();
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    if (!set.Contains (i)) set.Add (i);
                    n /= i;
                }
                else i++;
            }

            answer = set.ToArray ();
            Array.Sort (answer);
            return answer;
        }
    }
}