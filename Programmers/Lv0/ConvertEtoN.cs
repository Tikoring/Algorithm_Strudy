using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ConvertEtoN
    {
        public long Solution(string numbers) {
            long answer = 0;
            Dictionary<String, int> dict = new Dictionary<String, int> ()
            {
                ["zero"] = 0,
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5,
                ["six"] = 6,
                ["seven"] = 7,
                ["eight"] = 8,
                ["nine"] = 9
            };
            String[] strArr = {
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine"
            };

            foreach (String s in strArr)
            {
                numbers = numbers.Replace (s, dict[s].ToString ());
            }
            answer = long.Parse (numbers);
            return answer;
        }
    }
}