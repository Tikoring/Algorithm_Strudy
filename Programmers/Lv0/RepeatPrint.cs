using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class RepeatPrint
    {
        public String Solution(String myStr, int n) 
        {
            String answer = "";
            foreach (char ch in myStr)
                for (int i = 0; i < n; i++)
                    answer = answer.Insert (answer.Length, ch.ToString ());
            return answer;
        }
    }
}