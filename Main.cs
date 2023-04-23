using System;
using Programmers.Lv0.Problem;
using Programmers.Lv1.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            String[] input1 = {"con", "ryan"};
            String[] input2 = {"ryan con", "ryan con", "ryan con", "ryan con"};
            String[] input3 = {"i", "want", "to", "drink", "water"};
            int[] input = {2, 1, 1, 2, 3, 1, 2, 3, 1};
            ReportFeedback p = new ReportFeedback ();
            int[] answer = p.Solution (input1, input2, 3);

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}