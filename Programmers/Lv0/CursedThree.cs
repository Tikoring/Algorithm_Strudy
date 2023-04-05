using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class CursedThree
    {
        public int Solution(int n)
        {
            int answer = 0;
            int count = 0;
            while (count != n)
            {
                answer++;
                count++;
                String copy = answer.ToString ();
                if (copy.IndexOf ('3') != -1) count--;
                else if (answer % 3 == 0) count--;
            }
            return answer;
        }
    }
}