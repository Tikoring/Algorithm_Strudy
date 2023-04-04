using System;
using Programmers.Lv0.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            ChickenCoupon p = new ChickenCoupon ();
            int answer = p.Solution (100);

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}