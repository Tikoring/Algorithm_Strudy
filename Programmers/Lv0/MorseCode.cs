using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class MorseCode
    {
        Dictionary<String, char> morse = new Dictionary<string, char> () { 
            {".-", 'a'}, {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'}, {".",  'e'}, {"..-.", 'f'},
            {"--.", 'g'}, {"....", 'h'}, {"..", 'i'}, {".---", 'j'}, {"-.-", 'k'}, {".-..", 'l'},
            {"--", 'm'}, {"-.", 'n'}, {"---", 'o'}, {".--.", 'p'}, {"--.-", 'q'}, {".-.", 'r'},
            {"...", 's'}, {"-", 't'}, {"..-", 'u'}, {"...-", 'v'}, {".--", 'w'}, {"-..-", 'x'},
            {"-.--", 'y'}, {"--..", 'z'}
        };

        public String Solutio(String letter) 
        {
            String answer = "";
            String[] code = letter.Split (' ');
            foreach (String s in code)
                answer += morse[s];
            return answer;
        }
    }
}