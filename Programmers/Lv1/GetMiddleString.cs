using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class GetMiddleString
    {
        public String Solution(String s) 
        {
            String answer = "";
            bool even = s.Length % 2 == 0;
            answer = s.Substring (even ? s.Length / 2 - 1 : s.Length / 2, even ? 2 : 1);
            return answer;
        }
    }
}