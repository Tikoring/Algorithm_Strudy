using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class FractionAdd
    {
        public int[] Solution(int numer1, int denom1, int numer2, int denom2) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, 2);
            int n = numer1 * denom2 + numer2 * denom1;
            int d = denom1 * denom2;
            HashSet<int> factor = new HashSet<int> ();

            for (int i = 2; i < Math.Sqrt (n); i++)
                if (n % i == 0) factor.Add (i);
            for (int i = 2; i < Math.Sqrt (d); i++)
                if (d % i == 0) factor.Add (i);

            foreach (int i in factor)
                while (n % i == 0 && d % i == 0)
                {
                    n /= i;
                    d /= i;
                }
            

            answer[0] = n;
            answer[1] = d;

            return answer;
        }
    }
}