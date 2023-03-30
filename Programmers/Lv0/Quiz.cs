using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Solve
{
    public class Quiz
    {
        public String[] Solution(String[] quiz)
        {
            String[] answer = new String[quiz.Length];
            for (int i = 0; i < quiz.Length; i++)
            {
                string[] sp = quiz[i].Split (' ');
                int x = Int32.Parse (sp[0]);
                int y = Int32.Parse (sp[2]);
                int z = Int32.Parse (sp[4]);
                int result = 0;

                switch (sp[1]) 
                {
                    case "-" :
                        result = x - y;
                        break;
                    case "+" :
                        result = x + y;
                        break;
                }
                if (z == result) answer[i] = "O";
                else answer[i] = "X";
            }
            return answer;
        }   
    }
}