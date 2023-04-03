using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Decryption
    {
        public String Solution(String cipher, int code)
        {
            String answer = "";
            for (int i = code - 1; i < cipher.Length; i += code) {
                answer = answer.Insert(answer.Length, cipher[i].ToString ());
                Console.WriteLine (cipher[i]);
            }
            return answer;
        }
    }
}