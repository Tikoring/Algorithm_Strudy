using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Solve
{
    public class DigitSum
    {
        public int Solution(int n) 
        {
            int answer = 0;
            while (n > 0) {
                answer += n % 10;
                n /= 10;
            }
            return answer;
        }
    }
}