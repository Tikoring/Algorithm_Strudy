using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class BinarySum
    {
        public String Solution(String bin1, String bin2)
        {
            String answer = "";
            int b1 = 0;
            int b2 = 0;
            int result = 0;
            int d = (int) Math.Pow (2, bin1.Length - 1);
            foreach (char ch in bin1) 
            {
                b1 += (ch - '0') * d;
                d /= 2;
            }
            d = (int) Math.Pow (2, bin2.Length - 1);
            foreach (char ch in bin2) 
            {
                b2 += (ch - '0') * d;
                d /= 2;
            }
            result = b1 + b2;
            
            do
            {
                answer = answer.Insert (0, (result % 2).ToString ());
                result /= 2;
            } while (result > 0);

            return answer;
        }
    }
}