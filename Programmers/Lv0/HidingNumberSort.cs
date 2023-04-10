using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programmers.Lv0.Problem
{
    public class HidingNumberSort
    {
        public int[] Solution(String myStr) 
        {
            int[] answer = new int[] {};
            myStr = Regex.Replace (myStr, "[a-zA-Z]", "");
            Array.Resize (ref answer, myStr.Length);
            for (int i = 0; i < myStr.Length; i++)
                answer[i] = (int) myStr[i] - '0';

            Array.Sort (answer);
            return answer;
        }
    }
}