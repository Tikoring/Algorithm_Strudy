using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class PlanetOld
    {
        public String Solution(int age) 
        {
            String answer = "";
            while (age > 0)
            {
                int idx = age % 10;
                idx += (int) 'a';
                char ch = (char) idx;
                age /= 10;
                answer = answer.Insert (0, ch.ToString ());
            }
            return answer;
        }
    }
}