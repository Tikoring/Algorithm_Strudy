using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class LightCycle
    {
        private struct Dir 
        {
            public bool[] d;
            public Dir (int n)
            {
                d = new bool[n];
            }
        }
        private int[,] dn = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};
        public int[] Solution(string[] grid) 
        {
            List<int> answer = new List<int> ();
            Dir[,] use = new Dir[grid.Length, grid[0].Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    use[i, j] = new Dir (4);
                }
            }
            int[] node = {0, 0, 0};
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (use[i, j].d[k]) {continue;}
                        int c = 0;
                        node[0] = i;
                        node[1] = j;
                        node[2] = k;
                        while (node[2] != -1)
                        {
                            use[node[0], node[1]].d[node[2]] = true;
                            node[0] += dn[node[2], 0];
                            node[1] += dn[node[2], 1];
                            if (node[0] < 0) {node[0] = grid.Length - 1;}
                            else if (node[0] >= grid.Length) {node[0] = 0;}
                            else if (node[1] < 0) {node[1] = grid[0].Length - 1;}
                            else if (node[1] >= grid[0].Length) {node[1] = 0;}
                            char n = grid[node[0]][node[1]];

                            if (n == 'L') {node[2] -= 1;}
                            else if (n == 'R') {node[2] += 1;}
                            if (node[2] >= 4) {node[2] = 0;}
                            else if (node[2] < 0) {node[2] = 3;}
                            if (use[node[0], node[1]].d[node[2]])
                            {
                                node[2] = -1;
                            }
                            c++;
                        }
                        if (c != 0)
                        {
                            answer.Add (c);
                        }
                    }
                }
            }

            answer.Sort ();
            return answer.ToArray ();
        }
    }
}