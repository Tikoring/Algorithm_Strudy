using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class SafetyArea
    {
        public int Solution(int[,] board)
        {
            int answer = 0;
            int size = board.GetLength (0);
            bool[,] safety = new bool [size, size];
            int[] dx = {0, 1, 1, 1, 0, -1, -1, -1};
            int[] dy = {1, 1, 0, -1, -1, -1, 0, 1};
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    safety[i, j] = true;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++) 
                {
                    if (board[i, j] == 1)
                    {
                        safety[i, j] = false;
                        for (int d = 0; d < 8; d++)
                        {
                            if (dx[d] + i < 0 || dx[d] + i >= size) continue;
                            if (dy[d] + j < 0 || dy[d] + j >= size) continue;
                            safety[dx[d] + i, dy[d] + j] = false;
                        }
                    }

                }
            }

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (safety[i, j]) answer++;
            
            return answer;
        }
    }
}