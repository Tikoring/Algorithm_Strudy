using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class IntegerDesc
    {
        public long Solution(long n) 
        {
            long answer = 0;
            char[] s = n.ToString ().ToCharArray ();
            Array.Sort (s);
            s = s.Reverse ().ToArray ();
            answer = Int64.Parse (new String (s));
            return answer;
        }
    }
}