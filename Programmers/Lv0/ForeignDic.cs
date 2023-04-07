using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ForeignDic
    {
        public int Solution(String[] spell, String[] dic) 
        {
            int answer = 2;
            bool check = false;
            char[] sp = new char[spell.Length];
            for (int i = 0; i < spell.Length; i++)
            {
                sp[i] = spell[i][0];
            }
            foreach (String s in dic)
            {
                Dictionary<char, int> counter = new Dictionary<char, int> ();
                foreach (char ch in sp)
                    counter.Add (ch, 0);

                foreach (char ch in s)
                {
                    if (counter.ContainsKey (ch))
                    {
                        if (counter[ch] > 0) break;
                        counter[ch]++;
                    } else break;
                }
                foreach (char ch in sp)
                    if (counter[ch] != 1) 
                    {
                        check = false;
                        break;
                    }
                    else check = true;
                if (check) answer = 1;
            }
            return answer;
        }
    }
}