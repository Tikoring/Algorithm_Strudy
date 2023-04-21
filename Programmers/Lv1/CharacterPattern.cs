using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class CharacterPattern
    {
        public String solution(String[] survey, int[] choices) 
        {
            String answer = "";
            StringBuilder maker = new StringBuilder ();
            Dictionary<char, int> totalPoint = new Dictionary<char, int> ()
            {
                {'R', 0}, {'T', 0}, {'C', 0}, {'F', 0}, 
                {'J', 0}, {'M', 0}, {'A', 0}, {'N', 0}
            };
            Dictionary<int, int> score = new Dictionary<int, int> ()
            {
                {1, 3}, {2, 2}, {3, 1}, {4, 0}, {5, 1}, {6, 2}, {7, 3}
            };
            String[] type = {"RT", "CF", "JM", "AN"};

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i] > 4)
                {
                    totalPoint[survey[i][1]] += score[choices[i]];
                }
                else
                {
                    totalPoint[survey[i][0]] += score[choices[i]];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (totalPoint[type[i][0]] >= totalPoint[type[i][1]]) maker = maker.Append (type[i][0]);
                else maker = maker.Append (type[i][1]);
            }

            answer = maker.ToString ();
            return answer;
        }
    }
}