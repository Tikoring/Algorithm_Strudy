using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ReverseString
    {
        public String Solution(String myStr) 
        {
            String answer = new String (myStr.Reverse ().ToArray ());
            return answer;
        }
    }
}