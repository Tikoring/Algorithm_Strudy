using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class ReportFeedback
    {
        public int[] Solution(string[] idList, string[] report, int k) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, idList.Length);
            Dictionary<String, HashSet<String>> reporter = new Dictionary<string, HashSet<string>> ();
            Dictionary<String, HashSet<String>> reported = new Dictionary<string, HashSet<string>> ();
            for (int i = 0; i < report.Length; i++)
            {
                String[] tmp = report[i].Split (' ');
                if (reporter.ContainsKey (tmp[0]))
                {
                    reporter[tmp[0]].Add (tmp[1]);
                }
                else 
                {
                    HashSet<String> list = new HashSet<string> ();
                    list.Add (tmp[1]);
                    reporter.Add (tmp[0], list);
                }

                if (reported.ContainsKey (tmp[1]))
                {
                    reported[tmp[1]].Add (tmp[0]);
                }
                else 
                {
                    HashSet<String> list = new HashSet<string> ();
                    list.Add (tmp[0]);
                    reported.Add (tmp[1], list);
                }
            }
            for (int i = 0; i < idList.Length; i++)
            {
                if (reporter.ContainsKey (idList[i]))
                {
                    foreach (String name in reporter[idList[i]])
                    {
                        if (reported[name].Count >= k) answer[i]++;
                    }
                }
            }
            
            return answer;
        }
    }
}