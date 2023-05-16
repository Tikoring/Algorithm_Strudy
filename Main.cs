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
            int[] input1 = {100, 100, 200, 300, 400};
            int[] input2 = {};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{7, 7}, {2, 7}, {7, 3}};
            SeesawPair p = new SeesawPair ();
            long answer = p.Solution (input1);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}