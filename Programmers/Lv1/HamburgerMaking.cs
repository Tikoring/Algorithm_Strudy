using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class HamburgerMaking
    {
        public int Solution(int[] ingredient) 
        {
            int answer = 0;
            char[] make = new char[ingredient.Length];
            int idx = 0;
            
            foreach (int n in ingredient)
            {
                make[idx++] = (char) (n + '0');
                if (idx >= 4)
                {
                    String tmp = new String (make, idx - 4, 4);
                    if (String.Compare (tmp, "1231") == 0)
                    {
                        answer++;
                        idx -= 4;
                    }
                }
            }

            return answer;
        }
    }
}