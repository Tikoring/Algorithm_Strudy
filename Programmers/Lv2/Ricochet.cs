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
            int answer = 0;
            bool isFinish = false;
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
            
            do
            {
                int[][] d = {{0, -1}, {-1, 0}, {0, 1}, {1, 0}};
                if (wait.Count == 0)
                {
                    isMove[start[0], start[1]] = true;
                    for (int i = 0; i < 4; i++)
                    {
                        int x = start[0] + d[i][0];
                        int y = start[1] + d[i][1];
                        if (x >= v || x < 0 || y >= h || y < 0) continue;
                        else if (board[x][y] == 'D') continue;
                        wait.Enqueue (d[i]);
                    }
                }
                else 
                {
                    
                }
            } while (wait.Count > 0);

            
            return answer;
        }
    }
}