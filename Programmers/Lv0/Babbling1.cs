using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Babbling1
    {
        public int Solution(string[] babbling) 
        {
            int answer = 0;
            String[] voca = {"aya", "ye", "woo", "ma"};

            foreach (String b in babbling)
            {
                String tmp = b;
                char c = '-';
                foreach (String v in voca)
                {
                    tmp = tmp.Replace (v, "-");
                }
                int match = tmp.Count (f => (f == c));
                if (match == tmp.Length) answer++;
            }
            return answer;
        }
    }
}