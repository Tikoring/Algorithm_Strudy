using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class MazeRun
    {
        public int Solution(string[] maps) 
        {
            int answer = 0;
            bool isExit = false;
            bool isLever = false;
            bool[,] findLever = new bool[maps.Length, maps[0].Length];
            bool[,] findExit = new bool[maps.Length, maps[0].Length];
            int[,] dir = {
                {-1, 0}, {0, -1}, {1, 0}, {0, 1}
            };
            Queue<int[]> wait = new Queue<int[]> ();

            for (int i = 0; i < maps.Length; i++)
            {
                for (int j = 0; j < maps[0].Length; j++)
                {
                    if (maps[i][j] == 'S')
                    {
                        findLever[i, j] = true;
                        int[] p = {i, j, 0};
                        wait.Enqueue (p);
                    }
                    else if (maps[i][j] == 'L')
                    {
                        findExit[i, j] = true;
                    }
                }
            }

            while (!isLever && wait.Count > 0)
            {
                int[] p = wait.Dequeue ();
                for (int i = 0; i < 4; i++)
                {
                    int[] dp = {p[0] + dir[i, 0], p[1] + dir[i, 1], p[2] + 1};
                    if (dp[0] < 0 || dp[0] >= maps.Length || dp[1] < 0 || dp[1] >= maps[0].Length) continue;
                    else if (maps[dp[0]][dp[1]] == 'X') continue;
                    else if (findLever[dp[0], dp[1]]) continue;

                    if (maps[dp[0]][dp[1]] == 'L')
                    {
                        isLever = true;
                        wait.Clear ();
                        wait.Enqueue (dp);
                        break;
                    }
                    findLever[dp[0], dp[1]] = true;
                    wait.Enqueue (dp);
                }
            }
            if (!isLever) return -1;

            while (!isExit && wait.Count > 0)
            {
                int[] p = wait.Dequeue ();
                for (int i = 0; i < 4; i++)
                {
                    int[] dp = {p[0] + dir[i, 0], p[1] + dir[i, 1], p[2] + 1};
                    if (dp[0] < 0 || dp[0] >= maps.Length || dp[1] < 0 || dp[1] >= maps[0].Length) continue;
                    else if (maps[dp[0]][dp[1]] == 'X') continue;
                    else if (findExit[dp[0], dp[1]]) continue;

                    if (maps[dp[0]][dp[1]] == 'E')
                    {
                        isExit = true;
                        wait.Clear ();
                        wait.Enqueue (dp);
                        break;
                    }
                    findExit[dp[0], dp[1]] = true;
                    wait.Enqueue (dp);
                }
            }
            if (!isExit) return -1;
            answer = wait.Dequeue ()[2];
            
            return answer;
        }
    }
}