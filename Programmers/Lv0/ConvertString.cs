using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ConvertString
    {
        public int Solution(String before, String after)
        {
            int answer = 1;
            Dictionary<char, int> bNum = new Dictionary<char, int> ();
            Dictionary<char, int> fNum = new Dictionary<char, int> ();
            for (int i = 0; i < before.Length; i++)
            {
                if (bNum.ContainsKey (before[i])) bNum[before[i]]++;
                else 
                {
                    bNum.Add (before[i], 1);
                    fNum.Add (before[i], 0);
                }
            }

            for (int i = 0; i < before.Length; i++)
            {
                if (fNum.ContainsKey (after[i])) fNum[after[i]]++;
                else fNum.Add (after[i], 1);
            }
            char[] letters = bNum.Keys.ToArray ();
            foreach (char ch in letters)
            {
                if (bNum[ch] != fNum[ch]) 
                {
                    answer = 0;
                    break;
                }
            }

            return answer;
        }
    }
}