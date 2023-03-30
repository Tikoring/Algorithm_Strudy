using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class FindNumber
    {
        public int Solution(int num, int k) 
        {
            int answer = -1;
            string s = num.ToString ();
            answer = s.IndexOf ((char) (k + '0'));
            return answer == -1 ? -1 : answer + 1;
        }
    }
}