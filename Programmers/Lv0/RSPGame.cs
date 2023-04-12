using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class RSPGame
    {
        public String Solution(String rsp) 
        {
            String answer = "";
            foreach (char ch in rsp)
            {
                if (ch == '2') answer += "0";
                else if (ch == '0') answer += "5";
                else answer += "2";
            }
            return answer;
        }
    }
}