using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers
{
    public class StringSort2
    {
        public String Solution(String myStr)
        {
            String answer;
            myStr = myStr.ToLower ();
            char[] chArray = myStr.ToCharArray ();
            Array.Sort (chArray);
            answer = new String (chArray);
            return answer;   
        }
    }
}