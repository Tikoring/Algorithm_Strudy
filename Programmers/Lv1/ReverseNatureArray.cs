using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class ReverseNatureArray
    {
        public int[] Solution(long n) 
        {
            int[] answer = new int[] {};
            List<int> l = new List<int> ();
            
            while (n > 0)
            {
                l.Add ((int) n % 10);
                n /= 10;
            }
            answer = l.ToArray ();
            
            return answer;
        }
    }
}