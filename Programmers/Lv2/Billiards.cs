using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class Billiards
    {
        public int[] Solution(int m, int n, int startX, int startY, int[,] balls) 
        {
            List<int> answer = new List<int> ();
            int[] start = {startX, startY};
            int[,] lines = {
                {0, 0}, {0, 0}, {0, n}, {m, 0}
            };
            int[,] dots = {
                {0, 0}, {0, n}, {m, n}, {m, 0}
            };
            List<int> movement = new List<int> ();
            
            for (int i = 0; i < balls.GetLength (0); i++)
            {
                movement.Clear ();

                for (int j = 0; j < 4; j++)
                {
                    int d = 0;
                    int[] lSym = {balls[i, 0], balls[i, 1]};
                    if (j % 2 == 0)
                    {
                        if (lSym[1] > lines[j, 1]) 
                        {
                            if (lSym[0] == start[0] && lSym[1] < start[1]) continue;
                            lSym[1] *= -1;
                        }
                        else 
                        {
                            if (lSym[0] == start[0] && lSym[1] > start[1]) continue;
                            lSym[1] += 2 * (lines[j, 1] - lSym[1]);
                        }
                    }
                    else 
                    {
                        if (lSym[0] > lines[j, 0]) 
                        {
                            if (lSym[1] == start[1] && lSym[0] < start[0]) continue;
                            lSym[0] *= -1;
                        }
                        else 
                        {
                            if (lSym[1] == start[1] && lSym[0] > start[0]) continue;
                            lSym[0] += 2 * (lines[j, 0] - lSym[0]);
                        }
                    }
                    d = (int) (Math.Pow (lSym[0] - start[0], 2) + Math.Pow (lSym[1] - start[1], 2));
                    movement.Add (d);
                }

                for (int j = 0; j < 4; j++)
                {
                    int d = 0;
                    int[] dSym = {balls[i, 0], balls[i, 1]};
                    if (Math.Abs (dSym[0] - dots[j, 0]) * Math.Abs (start[1] - dots[j, 1]) != Math.Abs (dSym[1] - dots[j, 1]) * Math.Abs (start[0] - dots[j, 0]) &&
                        Math.Pow (dSym[0] - dots[j, 0], 2) + Math.Pow (dSym[1] - dots[j, 1], 2) < Math.Pow (start[0] - dots[j, 0], 2) + Math.Pow (start[1] - dots[j, 1], 2)) continue;
                    dSym[0] -= dots[j, 0];
                    dSym[1] -= dots[j, 1];
                    dSym[0] *= -1;
                    dSym[1] *= -1;
                    dSym[0] += dots[j, 0];
                    dSym[1] += dots[j, 1];
                    
                    d = (int) (Math.Pow (dSym[0] - start[0], 2) + Math.Pow (dSym[1] - start[1], 2));

                    movement.Add (d);
                }

                answer.Add (movement.Min ());
            }

            return answer.ToArray ();
        }
    }
}