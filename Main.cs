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
            int[,] input = {{2,2,6}, {1,5,10}, {4,2,9}, {3,8,3}};
            CardDividing p = new CardDividing ();
            int answer = p.Solution (input1, input2);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}