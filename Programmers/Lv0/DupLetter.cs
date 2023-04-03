using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class DupLetter
    {
        public String Solution(String myStr)
        {
            String answer = "";
            HashSet<char> letterSet = new HashSet<char> ();
            foreach (char ch in myStr)
            {
                if (!letterSet.Contains (ch))
                {
                    answer = answer.Insert (answer.Length, ch.ToString ());
                    letterSet.Add (ch);
                }
            }
            return answer;
        }
    }
}