using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Parallel
    {
        public int Solution(int[,] dots)
        {
            int answer = 0;
            double[] s1 = new double[3];
            double[] s2 = new double[3];
            int idx1 = 0;
            int idx2 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    double y= Math.Abs (dots[i, 1] - dots[j, 1]);
                    double x= Math.Abs (dots[i, 0] - dots[j, 0]);
                    if (i == 0) s1[idx1++] = y / x;
                    else s2[idx2++] = y / x;
                }
            }
            
            for (int i = 0; i < 3; i++)
                if (Math.Equals (s1[i], s2[2 - i]))
                {
                    answer = 1;
                    break;
                }

            return answer;
        }

        private int Euclidean (int a, int b)
        {
            return b != 0 ? Euclidean (b, a % b) : a;
        }
    }
}