using System;
using Programmers.Lv0.Problem;
using Programmers.Lv1.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            int[] input1 = {1, 5, 2, 6, 3, 7, 4};
            int[,] input2 = {{2, 5, 3}, {4, 4, 1}, {1, 7, 3}};
            String[] input3 = {"sun", "bed", "car"};
            int[] input = {1,2,7,6,4};
            CustomStringSorting p = new CustomStringSorting ();
            String[] answer = p.Solution (input3, 1);

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}