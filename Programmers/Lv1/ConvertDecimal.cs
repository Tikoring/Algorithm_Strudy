using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class ConvertDecimal
    {
        public int Solution(int n) 
        {
            int answer = 0;
            StringBuilder maker = new StringBuilder ();
            while (n > 0)
            {
                int i = n % 3;
                n /= 3;
                maker.Append (i);
            }

            String tri = new String (maker.ToString ().Reverse ().ToArray ());
            for (int i = 0; i < tri.Length; i++)
            {
                answer += (int) Math.Pow (3, i) * Int32.Parse (tri[i].ToString ());
            }
            return answer;
        }
    }
}