using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class CompareByNth : IComparer<String>
    {
        private int nth;

        public CompareByNth (int n)
        {
            this.nth = n;
        }

        public int Compare (String x, String y)
        {
            char nthX = x[nth];
            char nthY = y[nth];

            if (nthX.CompareTo (nthY) == 0)
            {
                return x.CompareTo (y);
            }

            return nthX.CompareTo (nthY);
        }
    }
    public class CustomStringSorting
    {
        public String[] Solution(String[] strings, int n) 
        {
            String[] answer = new String[] {};
            CompareByNth cmp = new CompareByNth (n);
            Array.Sort (strings, cmp);
            answer = strings;
            return answer;
        }
    }
}