using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class StringSplit
    {
        public int Solution(String s) 
        {
            int answer = 0;
            HashSet<char> now = new HashSet<char> ();
            Dictionary<char, int> counter = new Dictionary<char, int> ();
            foreach (char c in s)
            {
                now.Add (c);
                if (counter.ContainsKey (c)) counter[c] += 1;
                else counter.Add (c, 1);
                if (now.Count >= 2)
                {
                    bool comp = false;
                    int num = 0;
                    foreach (char n in now)
                    {
                        if (num == 0) num = counter[n];
                        else if (num == counter[n]) comp = true;
                        else comp = false;
                    }
                    if (comp)
                    {
                        now.Clear ();
                        counter.Clear ();
                        answer += 1;
                    }
                }
            }
            if (now.Count > 0) answer += 1;
            return answer;
        }
    }
}   