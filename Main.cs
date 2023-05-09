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
            int[] input1 = {1, 0, 1};
            int[] input2 = {};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{7, 7}, {2, 7}, {7, 3}};
            IslandTravel p = new IslandTravel ();
            int[] answer = p.Solution (input3);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}