using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class StringSorting
    {
        public String Solution(String s) 
        {
            String answer = "";
            char[] chs = s.ToCharArray ();
            Array.Sort (chs);
            Array.Reverse (chs);
            answer = new String (chs);
            return answer;
        }
    }
}