using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Polynomial
    {
        public String Solution(String polynomial) 
        {
            String answer = "";
            String[] variables = polynomial.Split (' ');
            int x = 0;
            int d = 0;
            foreach (String s in variables)
            {
                if (!s.Equals ("+"))
                    if (s.Contains ("x"))
                    {
                        int idx = s.IndexOf ('x');
                        if (idx == 0) x += 1;
                        else x += Int32.Parse (s.Substring (0, idx));
                    } else 
                    {
                        d += Int32.Parse (s);
                    }
            }
            if (x > 0) 
                if (x == 1) answer += "x";
                else answer += x.ToString () + "x";
            if (d > 0) 
                if (answer.Length > 0) answer += " + " + d.ToString ();
                else answer += d.ToString ();
            return answer;
        }
    }
}