using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Similar
    {
        public int Solution(String[] s1, String[] s2) 
        {
            int answer = 0;
            Dictionary<String, int> similarity = new Dictionary<String, int> ();
            foreach (String s in s1)
            {
                if (similarity.ContainsKey (s)) similarity[s]++;
                else similarity.Add (s, 1);
            }
            foreach (String s in s2)
            {
                if (similarity.ContainsKey (s)) similarity[s]++;
                else similarity.Add (s, 1);
            }
            Dictionary<String, int>.ValueCollection valueColl = similarity.Values;
            answer = Array.FindAll (valueColl.ToArray (), n => n == 2).Length;
            return answer;
        }
    }
}