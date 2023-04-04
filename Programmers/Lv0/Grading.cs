using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Grading
    {
        public int[] solution(int[,] score)
        {
            int[] answer = new int[] {};
            double[] meanScore = new double[] {};
            Array.Resize (ref answer, score.GetLength (0));
            Array.Resize (ref meanScore, score.GetLength (0));
            Dictionary<double, int> gd = new Dictionary<double, int> ();
            for (int i = 0; i < answer.Length; i++)
            {
                double eng = score[i, 0];
                double mt = score[i, 1];
                meanScore[i] = (eng + mt) / 2;
                if (gd.ContainsKey (meanScore[i])) gd[meanScore[i]]++;
                else gd.Add (meanScore[i], 1);
            }
            double[] ss = gd.Keys.ToArray ();
            Array.Sort (ss);
            Array.Reverse (ss);
            int prev = 0;
            int grade = 1;
            foreach (double i in ss)
            {
                prev = gd[i];
                gd[i] = grade;
                grade += prev;
            }
            
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = gd[meanScore[i]];
            }
            return answer;
        }
    }
}