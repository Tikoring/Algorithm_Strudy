using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class DigitAdd
    {
        public int Solution(int n) 
        {
            int answer = 0;
            while (n > 0)
            {
                answer += n % 10;
                n /= 10;
            }
            return answer;
        }
    }
}