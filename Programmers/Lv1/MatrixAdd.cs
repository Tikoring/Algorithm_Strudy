using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class MatrixAdd
    {
        public int[,] Solution(int[,] arr1, int[,] arr2) 
        {
            int[,] answer = new int[,] {{}};
            for (int i = 0; i < arr1.GetLength (0); i++)
                for (int j = 0; j < arr1.GetLength (1); j++)
                    arr1[i, j] += arr2[i , j];
            answer = arr1;
            return answer;
        }
    }
}