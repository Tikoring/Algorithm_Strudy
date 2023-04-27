using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class FindPrime
    {
        public int Solution(int n) 
        {
            int answer = 0;
            bool[] notPrime = new bool[n + 1];
            notPrime[0] = true;
            notPrime[1] = true;

            for (int i = 2; i * i <= n; i++)
            {
                if (notPrime[i]) continue;
                for (int j = 2; i * j <= n; j++)
                {
                    notPrime[j * i] = true;
                }
            }

            for (int i = 0; i <= n; i++)
            {
                if (!notPrime[i]) answer++;
            }

            return answer;
        }
    }
}