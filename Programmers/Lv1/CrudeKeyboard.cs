using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class CrudeKeyboard
    {
        public int[] Solution(String[] keymap, String[] targets) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, targets.Length);
            for (int i = 0; i < targets.Length; i++)
            {
                answer[i] = 0;
                foreach (char ch in targets[i])
                {
                    int idx = 101;
                    foreach (String key in keymap)
                    {
                        if (key.IndexOf (ch) > -1) idx = Math.Min (idx, key.IndexOf (ch) + 1);
                    }
                    if (idx == 101) 
                    {
                        answer[i] = -1;
                        break;
                    }
                    answer[i] += idx;
                }
            }
            return answer;
        }
    }
}