using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class CollatzIntegral
    {
        public double[] Solution(int k, int[,] ranges) 
        {
            List<double> answer = new List<double> ();
            Dictionary<int, int> p = new Dictionary<int, int> ();

            p.Add (0, k);
            for (int i = 1; k > 1; i++)
            {
                int n = 0;
                if (k % 2 ==0)
                {
                    n = k / 2;
                }
                else
                {
                    n = k * 3 + 1; 
                }
                p.Add (i, n);
                k = n;
            }
            int last = p.Count - 1;

            for (int i = 0; i < ranges.GetLength (0); i++)
            {
                ranges[i, 1] += last;
            }

            for (int i = 0; i < ranges.GetLength (0); i++)
            {
                if (ranges[i, 0] > ranges[i, 1])
                {
                    answer.Add (-1.0);
                }
                else
                {
                    double d = 0;
                    for (int j = ranges[i, 0]; j < ranges[i, 1]; j++)
                    {
                        d += (double) (p[j] + p[j + 1]) / 2;
                    }
                    answer.Add (d);
                }
            }

            return answer.ToArray ();
        }
    }
}