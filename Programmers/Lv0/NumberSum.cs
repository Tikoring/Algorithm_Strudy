using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programmers.Lv0.Problem
{
    public class NumberSum
    {
        public int Solution(String myStr)
        {
            int answer = 0;
            myStr = Regex.Replace (myStr, "[A-Za-z]", " ");
            
            String[] nums = myStr.Split (' ');
            for (int i = 0; i < nums.Length; i++)
                if (!nums[i].Equals ("")) answer += Int32.Parse (nums[i]);
        }
    }
}