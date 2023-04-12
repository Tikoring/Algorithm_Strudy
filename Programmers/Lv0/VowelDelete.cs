using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programmers.Lv0.Problem
{
    public class VowelDelete
    {
        public string Solution(String myStr) 
        {
            String answer = "";
            answer = Regex.Replace (myStr, "[aeiou]", "");
            return answer;
        }
    }
}