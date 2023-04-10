using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class CtrlZ
    {
        public int Solution(String s) 
        {
            int answer = 0;
            String[] list = s.Split (' ');
            int before = Int32.Parse (list[0]);
            answer = before;
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i].Equals ("Z")) 
                {
                    answer -= before;
                    continue;
                }
                before = Int32.Parse (list[i]);
                answer += before;
            }
            return answer;
        }
    }
}