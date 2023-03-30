using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Solve
{
    public class StringString
    {
        public int Solution(String str1, String str2)
        {
            int answer = 2;
            if (str1.IndexOf (str2) != -1) answer = 1;
            return answer;
        }
    }
}