using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class NumberPair
    {
        public String Solution(String X, String Y) 
        {
            String answer = "";
            StringBuilder maker = new StringBuilder ();
            char[] strX = X.ToCharArray ();
            char[] strY = Y.ToCharArray ();
            Array.Sort (strX);
            Array.Sort (strY);
            strX = strX.Reverse ().ToArray ();
            strY = strY.Reverse ().ToArray ();
            X = new String (strX);
            Y = new String (strY);
            char maximum = (char) Math.Max (X[0], Y[0]);

            for (char ch = maximum; ch >= '0'; ch--)
            {
                int s1 = 0, s2 = 0, e1 = 0, e2 = 0;
                s1 = X.IndexOf (ch);
                s2 = Y.IndexOf (ch);
                e1 = X.LastIndexOf (ch);
                e2 = Y.LastIndexOf (ch);
                if (s1 == -1 || s2 == -1) continue;
                maker = maker.Append (ch, Math.Min (e1 - s1 + 1, e2 - s2 + 1));
            }

            answer = maker.ToString ();
            if (answer.Length == 0) answer = "-1";
            if (answer.Last () == '0' && answer.First () == '0') answer = "0";
            return answer;
        }
    }
}