using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class GCDandLCM
    {
        public int[] Solution(int n, int m) 
        {
            int[] answer = new int[2] {0, 0};
            int gcd = Math.Min (n, m);
            while (n % gcd != 0 || m % gcd != 0)
                gcd--;
            int f1 = n / gcd;
            int f2 = m / gcd;
            long lcm = f1 * f2 * gcd;
            
            answer[0] = gcd;
            answer[1] = (int) lcm;
            return answer;
        }
    }
}