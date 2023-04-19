using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class NearestCharacter
    {
        public int[] Solution(String s) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, s.Length);
            Dictionary<char, int> near = new Dictionary<char, int> ();
            for (int i = 0; i < s.Length; i++)
            {
                if (near.ContainsKey (s[i])) answer[i] = near[s[i]];
                else answer[i] = -1;
                near[s[i]] = i;
            }
            return answer;
        }
    }
}