using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class KnightageWeapon
    {
        public int Solution(int number, int limit, int power) 
        {
            int answer = 0;
            for (int i = 1; i <= number; i++)
            {
                int count = 0;
                int l = 0;
                int pp = 0;
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) count++;
                    l = j;
                }
                if (l * l == i) 
                {
                    count -= 1;
                    pp = 1;
                }
                pp += count * 2;
                if (pp > limit) answer += power;
                else answer += pp;
            }
            return answer;
        }
    }
}