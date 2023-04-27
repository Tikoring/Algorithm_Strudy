using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class StrangeCharMaker
    {
        public String Solution(String s) 
        {
            String answer = "";
            String[] words = s.Split (' ');
            StringBuilder maker = new StringBuilder ();
            foreach (String w in words)
            {
                for (int i = 0; i < w.Length; i++)
                {
                    if (i % 2 == 0) 
                    {
                        String tmp = w.ToUpper ();
                        maker.Append (tmp[i]);
                    }
                    else
                    {
                        String tmp = w.ToLower ();
                        maker.Append (tmp[i]);
                    }
                }
                maker.Append (' ');
            }
            maker.Remove (maker.Length - 1, 1);
            answer = maker.ToString ();
            return answer;
        }
    }
}