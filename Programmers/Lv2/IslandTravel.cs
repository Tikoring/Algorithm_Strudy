using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class IslandTravel
    {
        public int[] Solution(string[] maps) 
        {
            List<int> answer = new List<int> ();
            bool[,] isolation = new bool[maps.Length, maps[0].Length];
            Queue<int[]> land = new Queue<int[]> ();
            int[,] dir = {
                {0, 1}, {1, 0}, {0, -1}, {-1, 0}
            };
            for (int i = 0; i < maps.Length; i++)
            {
                for (int j = 0; j < maps[0].Length; j++)
                {
                    int d = 0;
                    if (maps[i][j] != 'X' && !isolation[i, j])
                    {
                        int[] p = {i, j};
                        land.Enqueue (p);
                        isolation[i, j] = true;
                        d = Int32.Parse (maps[i].Substring (j, 1));
                        while (land.Count > 0)
                        {
                            p = land.Dequeue ();
                            for (int k = 0; k < 4; k++)
                            {
                                int[] np = {p[0] + dir[k, 0], p[1] + dir[k, 1]};
                                if (np[0] < 0 || np[0] >= maps.Length || np[1] < 0 || np[1] >= maps[0].Length) continue;
                                else if (maps[np[0]][np[1]] == 'X') continue;
                                else if (isolation[np[0], np[1]]) continue;

                                land.Enqueue (np);
                                isolation[np[0], np[1]] = true;
                                d += Int32.Parse (maps[np[0]].Substring (np[1], 1));
                            }
                        }
                        answer.Add (d);
                    }
                }
            }
            if (answer.Count == 0) answer.Add (-1);
            answer.Sort ();
            return answer.ToArray ();
        }
    }
}