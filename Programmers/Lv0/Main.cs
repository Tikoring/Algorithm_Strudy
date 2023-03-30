using System;
using Programmers.Lv0.Problem;

namespace Programmers.Lv0.Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            string[] input1 = {"a", "b", "c"};
            string[] input2 = {"com", "b", "d", "p", "c"};
            Similar p = new Similar ();
            int answer = p.Solution (input1, input2);

            Console.WriteLine (answer);
        }
    }
}