using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class SwitchIndex
    {
        public String Solution(String myStr, int num1, int num2)
        {
            char ch1 = myStr[num1];
            char ch2 = myStr[num2];
            myStr = myStr.Remove(num1, 1).Insert (num1, ch2.ToString ());
            myStr = myStr.Remove(num2, 1).Insert (num2, ch1.ToString ());

            return myStr;
        }
    }
}