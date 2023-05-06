using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class Ricochet
    {
        public int Solution(String[] board) 
        {
            int answer = -1;
            bool isFinish = false;
            bool isStart = true;
            bool[,] isMove = new bool[board.Length, board[0].Length];
            int[] start = {0, 0};
            int[] goal = {0, 0};
            int v = board.Length;
            int h = board[0].Length;
            Queue<int[]> wait = new Queue<int[]> ();
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].IndexOf ('R') != -1)
                {
                    start[0] = i;
                    start[1] = board[i].IndexOf ('R');
                }
                if (board[i].IndexOf ('G') != -1)
                {
                    goal[0] = i;
                    goal[1] = board[i].IndexOf ('R');
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    isMove[i, j] = false;
                }
            }
            int[][] d = new int[4][];
            d[0] = new int [2] {0, -1};
            d[1] = new int [2] {-1, 0};
            d[2] = new int [2] {0, 1};
            d[3] = new int [2] {1, 0};
            do
            {
                if (wait.Count == 0)
                {
                    isMove[start[0], start[1]] = true;
                    for (int i = 0; i < 4; i++)
                    {
                        int[] dir = d[i];
                        int x = start[0] + dir[0];
                        int y = start[1] + dir[1];
                        int c = 1;
                        if (x >= v || x < 0 || y >= h || y < 0) continue;
                        else if (board[x][y] == 'D') continue;
                        
                        for (; (x + dir[0]) < v && (x + dir[0]) >= 0 && (y + dir[1]) < h && (y + dir[1]) >= 0 && board[x + dir[0]][y + dir[1]] != 'D';)
                        {
                            x += dir[0];
                            y += dir[1];
                        }
                        int[] p = {x, y, c};
                        isMove[p[0], p[1]] = true;
                        wait.Enqueue (p);
                    }
                    if (!isStart) break;
                    isStart = false;
                }
                else 
                {
                    int[] p = wait.Dequeue ();
                    for (int i = 0; i < 4; i++)
                    {
                        int[] dir = d[i];
                        int x = p[0] + dir[0];
                        int y = p[1] + dir[1];
                        int c = p[2] + 1;
                        if (x >= v || x < 0 || y >= h || y < 0) continue;
                        else if (board[x][y] == 'D') continue;
                        
                        for (; (x + dir[0]) < v && (x + dir[0]) >= 0 && (y + dir[1]) < h && (y + dir[1]) >= 0 && board[x + dir[0]][y + dir[1]] != 'D';)
                        {
                            x += dir[0];
                            y += dir[1];
                        }
                        int[] dp = {x, y, c};
                        if (board[dp[0]][dp[1]] == 'G')
                        {
                            isFinish = true;
                            answer = c;
                            break;
                        }
                        if (!isMove[dp[0], dp[1]])
                        {
                            wait.Enqueue (dp);
                            isMove[dp[0], dp[1]] = true;
                        }
                    }
                }
            } while (wait.Count > 0 && !isFinish);

            
            return answer;
        }
    }
}