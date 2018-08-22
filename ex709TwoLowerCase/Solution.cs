using System;
using System.Collections.Generic;
using System.Text;

namespace ex709ToLowerCase
{
    public class Solution
    {
        public string ToLowerCase(string str)
        {
            var cstr = str.ToCharArray();
            for (int i = 0; i < cstr.Length; i++)
            {
                if (cstr[i] > 64 &&cstr[i] < 91)
                    cstr[i] = (char)(cstr[i] + 32);
            }
            return new string(cstr);
        }
    }
}
