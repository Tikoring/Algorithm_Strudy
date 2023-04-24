using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class TrialExamination
    {
        public int[] Solution(int[] answers) 
        {
            int[] answer = new int[] {};
            String[] choices = {
                "12345", "21232425", "3311224455"
            };
            int[] score = {0, 0, 0};
            StringBuilder maker = new StringBuilder ();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < answers.Length / choices[i].Length; j++)
                {
                    maker.Append (choices[i]);
                }
                if (maker.Length < answers.Length) maker.Append (choices[i], 0, answers.Length % choices[i].Length);
                choices[i] = maker.ToString ();
                maker.Clear ();
            }

            for (int i = 0; i < answers.Length; i++) 
            {
                if (answers[i] == Int32.Parse (choices[0][i].ToString ()))
                    score[0]++;
                if (answers[i] == Int32.Parse (choices[1][i].ToString ()))
                    score[1]++;
                if (answers[i] == Int32.Parse (choices[2][i].ToString ()))
                    score[2]++;
            }
            int m = score.Max ();
            HashSet<int> a = new HashSet<int> ();
            for (int i = 0; i < 3; i++)
            {
                if (m == score[i])
                    a.Add (i + 1);
            }
            answer = a.ToArray ();
            return answer;
        }
    }
}