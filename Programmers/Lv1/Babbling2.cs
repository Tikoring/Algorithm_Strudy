using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class Babbling2
    {
        public int Solution(String[] babbling) 
        {
            int answer = 0;
            String[] able = {"aya", "ye", "woo", "ma"};
            for (int i = 0; i < babbling.Length; i++)
            {
                String before = "";
                for (int j = 0; j < 4; j++)
                {
                    if (String.Compare (able[j], before) == 0) continue;
                    int idx = babbling[i].IndexOf (able[j]);
                    if (idx == 0)
                    {
                        babbling[i] = babbling[i].Remove (0, able[j].Length);
                        before = able[j];
                        j = -1;
                    }
                    if (babbling[i].Length == 0) break;
                }
                if (babbling[i].Length == 0) answer++;
            }
            return answer;
        }
    }
}