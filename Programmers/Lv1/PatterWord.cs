using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class PatterWord
    {
        public String Solution(int n) 
        {
            String answer = "";
            StringBuilder maker = new StringBuilder ();
            String[] eachWord = {"수박", "수"};
            for (int i = 0; i < n / 2; i++)
            {
                maker.Append (eachWord[0], 0, 2);
            }
            if (n % 2 == 1) maker.Append (eachWord[1], 0, 1);
            answer = maker.ToString ();
            return answer;
        }
    }
}