using System;
using Programmers.Lv0.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            int[] input = {1, 2, 3, 4};
            EmergencyOrdered p = new EmergencyOrdered ();
            int[] answer = p.Solution (input);

            //Console.WriteLine (answer);
            foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }
        }
    }
}