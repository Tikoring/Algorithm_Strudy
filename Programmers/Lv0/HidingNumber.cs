using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programmers.Lv0.Problem
{
    public class HidingNumber
    {
        public int Solution(String myStr)
        {
            int answer = 0;
            myStr = Regex.Replace (myStr, "[a-zA-Z]", "");
            foreach (char ch in list)
            {
                answer += (int) ch - '0';
            }
            return answer;
        }
    }
}