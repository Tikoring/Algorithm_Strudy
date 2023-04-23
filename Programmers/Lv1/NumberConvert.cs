using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class NumberConvert
    {
        public int solution(String s) 
        {
            int answer = 0;
            StringBuilder maker = new StringBuilder ();
            maker.Append (s);
            maker.Replace ("zero", "0");
            maker.Replace ("one", "1");
            maker.Replace ("two", "2");
            maker.Replace ("three", "3");
            maker.Replace ("four", "4");
            maker.Replace ("five", "5");
            maker.Replace ("six", "6");
            maker.Replace ("seven", "7");
            maker.Replace ("eight", "8");
            maker.Replace ("nine", "9");
            s = maker.ToString ();
            answer = Int32.Parse (s);
            return answer;
        }
    }
}