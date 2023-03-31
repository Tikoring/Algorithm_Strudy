using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class StringFormular
    {
        public int Solution(String myStr)
        {
            int answer = 0;
            String[] strSp = myStr.Split (" ");
            int x = 0;
            int calc = 0;
            foreach (String s in strSp)
            {
                switch (s)
                {
                    case "+" :
                        calc = 1;
                        break;
                    case "-" :
                        calc = -1;
                        break;
                    default :
                        x = Int32.Parse (s);
                        if (calc == 1)          answer += Int32.Parse (s);
                        else if (calc == -1)    answer -= Int32.Parse (s);
                        else                    answer = Int32.Parse (s);
                        break;
                }
            }
            return answer;
        }
    }
}