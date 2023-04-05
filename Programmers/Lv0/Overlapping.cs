using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// 다시 풀이 요망
namespace Programmers.Lv0.Problem
{
    public class Overlapping
    {
        public int Solution(int[,] lines)
        {
            int answer = 0;
            int[] s = new int[3];
            int[] e = new int[3];
            Dictionary<int, int> overlap = new Dictionary<int, int> ();

            for (int i = 0; i < 3; i++)
            {
                s[i] = lines[i, 0];
                e[i] = lines[i, 1];
            }

            Array.Sort (s, e);

            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (s[j] < e[i])
                        if (e[j] > e[i])
                        {
                            if (overlap.ContainsKey (s[j])) overlap[s[j]] = e[i];
                            else overlap.Add (s[j], e[i]);
                        } else
                        {
                            if (overlap.ContainsKey (s[j])) overlap[s[j]] = e[j];
                            else overlap.Add (s[j], e[j]);
                        } 
                }
            }
            int prevE = -101;
            foreach (int n in overlap.Keys.ToArray ())
            {
                answer += overlap[n] - n;
                if (n < prevE) answer -= prevE - n;
                prevE = overlap[n];

            }
            return answer;
        }
    }
}