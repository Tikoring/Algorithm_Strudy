using System;
using Programmers.Lv0.Problem;
using Programmers.Lv1.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            String[] input1 = {"OSO","OOO","OXO","OOO"};
            String[] input2 = {"E 2","S 3","W 1"};
            ParkWalking p = new ParkWalking ();
            int[] answer = p.Solution (input1, input2);

            //Console.WriteLine (answer);
            foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }
        }
    }
}