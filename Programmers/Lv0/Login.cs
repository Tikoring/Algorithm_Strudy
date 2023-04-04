using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Login
    {
        public String Solution(String[] id_pw, String[,] db)
        {
            String answer = "fail";
            for (int i = 0; i < db.GetLength (0); i++) 
            {
                if (db[i, 0].Equals (id_pw[0]))
                    if (db[i, 1].Equals (id_pw[1])) answer = "login";
                    else answer = "wrong pw";
            }
            return answer;
        }
    }
}