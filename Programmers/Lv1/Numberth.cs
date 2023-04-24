using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class Numberth
    {
        public int[] Solution(int[] array, int[,] commands) 
        {
            int[] answer = new int[commands.GetLength (0)];
            for (int i = 0; i < answer.Length; i++)
            {
                int[] sorted = new int[commands[i, 1] - commands[i, 0] + 1];
                for (int j = commands[i, 0] - 1; j < commands[i, 1]; j++)
                {
                    sorted[j - (commands[i, 0] - 1)] = array[j];
                }
                Array.Sort (sorted);
                answer[i] = sorted[commands[i, 2] - 1];
            }
            return answer;
        }
    }
}