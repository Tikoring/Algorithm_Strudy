using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class InterceptionSystem
    {
        public int Solution(int[,] targets) 
        {
            int answer = 0;
            int l = targets.GetLength (0);
            int[] starts = new int[l];
            int[] ends = new int[l];
            bool[] shot = new bool[l];
            for (int i = 0; i < l; i++)
            {
                starts[i] = targets[i, 0];
                ends[i] = targets[i, 1];
                shot[i] = false;
            }

            Array.Sort (starts, ends);

            for (int i = 0; i < l; i++)
            {
                if (shot[i]) continue;
                shot[i] = true;
                int s = starts[i];
                int e = ends[i];
                for (int j = i + 1; j < l; j++)
                {
                    if (starts[j] >= e) break;
                    if (starts[j] >= s && starts[j] < e) 
                    {
                        shot[j] = true;
                        s = s >= starts[j] ? s : starts[j];
                        e = e <= ends[j] ? e : ends[j];
                    }
                }
                answer++;
            }


            return answer;
        }
    }
}