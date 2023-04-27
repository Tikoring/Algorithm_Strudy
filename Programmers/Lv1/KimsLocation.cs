using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class KimsLocation
    {
        public String Solution(String[] seoul) 
        {
            String answer = "";
            StringBuilder maker = new StringBuilder ();
            maker.Append ("김서방은");
            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i].CompareTo ("Kim") == 0)
                {
                    maker.Append (' ');
                    maker.Append (i + 1);
                    maker.Append ("에 ");
                    break;
                }
            }
            maker.Append ("있다");
            answer = maker.ToString ();
            
            return answer;
        }
    }
}