using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class UpperLower
    {
        public String Solution(String myStr) {
            String answer = "";
            int diff = 'a'-'A';
            foreach (char ch in myStr)
            {
                if (ch < 'a') answer += (char) (ch + diff);
                else answer += (char) (ch - diff);
            }

            return answer;
        }
    }
}