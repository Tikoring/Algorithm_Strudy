using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class MagicElevator
    {
        public int Solution(int storey) 
        {
            int answer = 0;
            while (storey > 0)
            {
                int n = storey % 10;
                storey /= 10;
                if (n > 5) 
                {
                    answer += 10 - n;
                    storey += 1;
                }
                else if (n == 5 && storey % 10 > 4)
                {
                    answer += 5;
                    storey += 1;
                }
                else 
                {
                    answer += n;
                }
            }

            return answer;
        }
    }
}