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
            int[] input1 = {2, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0};
            int[] input2 = {4, 6, 5, 1};
            String[] input3 = {"S"};
            int[,] input = {{1, 3}, {2, 3}, {3, 4}, {4, 5}, {4, 6}, {4, 7}, {7, 8}, {7, 9}};
            LightCycle p = new LightCycle ();
            int[] answer = p.Solution (input3);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}