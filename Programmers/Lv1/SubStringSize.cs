using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class SubStringSize
    {
        public int Solution(String t, String p) 
        {
            int answer = 0;
            long n2 = Int64.Parse (p);
            for (int i = 0; i < t.Length - p.Length + 1; i++)
            {
                long n1 = Int64.Parse (t.Substring (i, p.Length));
                if (n1 <= n2) answer +=1;
            }
            return answer;
        }
    }
}