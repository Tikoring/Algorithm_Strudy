using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class DuoCipher
    {
        public String Solution(String s, String skip, int index)
        {
            String answer = "";
            for (int i = 0; i < s.Length; i++)
            {
                int c = (int) s[i];
                int f = (int) 'a';
                int l = (int) 'z';
                for (int j = 0; j < index; j++)
                {
                    c++;
                    if (c > l) c = f;
                    while (skip.IndexOf ((char) c) != -1)
                    {
                        c++;
                        if (c > l) c = f;
                    }
                }
                answer += ((char) c).ToString ();
            }
            return answer;
        }
    }
}