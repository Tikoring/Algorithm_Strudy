using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programmers.Lv0.Problem
{
    public class CharacterDelete
    {
        public String Solution(String myStr, String letter) 
        {
            String answer = "";
            letter = letter.Insert (0, "[");
            letter = letter.Insert (2, "]");
            answer = Regex.Replace (myStr, letter, "");
            return answer;
        }
    }
}