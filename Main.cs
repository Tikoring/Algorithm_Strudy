using System;
using Programmers.Lv0.Problem;
using Programmers.Lv1.Problem;
using Programmers.Lv2.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            int[] input1 = {9, 1, 5, 3, 6, 2};
            int[] input2 = {};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{7, 7}, {2, 7}, {7, 3}};
            NumTrans p = new NumTrans ();
            int answer = p.Solution (10, 40, 5);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}