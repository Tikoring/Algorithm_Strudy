using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class SplitStore
    {
        public String[] Solution(String myStr, int n)
        {
            String[] answer = new String[] {};
            int size = myStr.Length % n == 0 ? myStr.Length / n : myStr.Length / n + 1;
            Array.Resize(ref answer, size);
            for (int i = 0; i < size; i++)
            {
                if (myStr.Length < n) 
                {
                    answer[i] = myStr.Substring (0);
                }
                else
                {
                    answer[i] = myStr.Substring (0, n);
                    myStr = myStr.Substring (n);
                }
                
            }
            return answer;
        }
    }
}