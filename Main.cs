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
            int[] input1 = {10, 17};
            int[] input2 = {5, 20};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{0, 0}, {0, -1}, {2, -3}, {3, -3}};
            CollatzIntegral p = new CollatzIntegral ();
            double[] answer = p.Solution (5, input);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}