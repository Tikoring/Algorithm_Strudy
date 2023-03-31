using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class OnceChar
    {
        public String Solution(String s)
        {
            String answer = "";
            Dictionary<char, int> noc = new Dictionary<char, int> ();
            foreach (char ch in s)
            {
                if (noc.ContainsKey (ch)) noc[ch]++;
                else noc.Add (ch, 1);
            }

            foreach (char ch in s)
            {
                if (noc[ch] == 1)
                {
                    answer += ch;
                }
            }
            answer = String.Concat (answer.OrderBy (ch => ch));
            return answer;
        }
    }
}