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
            String[] input3 = {"O.X", ".OX", "X.O"};
            int[,] input = {{7, 7}, {2, 7}, {7, 3}};
            SingleTicTacToe p = new SingleTicTacToe ();
            int answer = p.Solution (input3);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}