using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ElementLength
    {
        public int[] Solution(String[] strlist) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, strlist.Length);

            for (int i = 0; i < strlist.Length; i++) 
                answer[i] = strlist[i].Length;
            return answer;
        }
    }
}