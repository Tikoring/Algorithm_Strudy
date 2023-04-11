using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class DimensionChange
    {
        public int[,] Solution(int[] numList, int n)
        {
            int[,] answer = new int[,] {{}};
            int size = numList.Length;
            int[,] copy = new int[size / n, n];
            for (int i = 0; i < size; i++)
                copy[i / n, i % n] = numList[i];
            answer = copy;
            return answer;
        }
    }
}