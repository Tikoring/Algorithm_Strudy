using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class CaeserCode
    {
        public String Solution(String s, int n) 
        {
            String answer = "";
            char[] fin = {'z', 'Z'};
            int diff = (int) ('z' - 'a' + 1);
            StringBuilder maker = new StringBuilder ();
            foreach (char ch in s)
            {
                char change = (char) (ch + n);
                if (ch >= 'a' && ch <= 'z' && change > fin[0])
                {
                    change = (char) (change - diff);
                    maker.Append (change);
                }
                else if (ch >= 'A' && ch <= 'Z' && change > fin[1])
                {
                    change = (char) (change - diff);
                    maker.Append (change);
                }
                else if (ch == ' ')
                {
                    maker.Append (ch);
                }
                else
                {
                    maker.Append (change);
                }
            }
            answer = maker.ToString ();
            return answer;
        }
    }
}