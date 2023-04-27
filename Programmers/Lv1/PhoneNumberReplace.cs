using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class PhoneNumberReplace
    {
        public String Solution(String phoneNumber) 
        {
            String answer = "";
            StringBuilder maker = new StringBuilder ();
            maker.Append ('*', phoneNumber.Length - 4);
            maker.Append (phoneNumber.Substring (phoneNumber.Length - 4));
            answer = maker.ToString ();
            return answer;
        }
    }
}