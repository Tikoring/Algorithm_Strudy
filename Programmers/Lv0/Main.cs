using System;
using Programmers.Lv0.Problem;

namespace Programmers.Lv0.Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            StringPush p = new StringPush ();
            int answer = p.Solution ("hello", "ohell");

            Console.WriteLine (answer);
        }
    }
}