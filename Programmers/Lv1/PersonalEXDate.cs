using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class PersonalEXDate
    {
        public int[] Solution(String today, String[] terms, String[] privacies) 
        {
            int[] answer = new int[] {};
            Dictionary<char, int> clause = new Dictionary<char, int> ();
            String[] now = today.Split ('.');
            int nowY = Int32.Parse (now[0]);
            int nowM = Int32.Parse (now[1]);
            int nowD = Int32.Parse (now[2]);
            foreach (String t in terms)
                clause.Add (t[0], Int32.Parse (t.Substring (2)));

            for (int i = 0; i < privacies.Length; i++)
            {
                char name = privacies[i].Last ();
                int period = clause[name];
                String[] date = privacies[i].Substring (0, privacies[i].IndexOf (' ')).Split ('.');
                int y = Int32.Parse (date[0]);
                int m = Int32.Parse (date[1]) + period;
                int d = Int32.Parse (date[2]) - 1;
                if (d == 0)
                {
                    m -= 1;
                    d = 28;
                }
                while (m > 12)
                {
                    m -= 12;
                    y += 1;
                }
                
                if (nowY > y) answer = answer.Append (i + 1).ToArray ();
                else if (nowY == y && nowM > m) answer = answer.Append (i + 1).ToArray ();
                else if (nowY == y && nowM == m && nowD > d) answer = answer.Append (i + 1).ToArray ();
            }
            
            return answer;
        }
    }
}