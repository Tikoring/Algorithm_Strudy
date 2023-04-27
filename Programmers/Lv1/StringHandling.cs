using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programmers.Lv1.Problem
{
    public class StringHandling
    {
        public bool Solution(String s) 
        {
            bool answer = true;
            
            if (s.Length != 4 && s.Length != 6) answer = false;
            else if (Regex.IsMatch (s, "[a-zA-Z]") ) answer = false;
            return answer;
        }
    }
}