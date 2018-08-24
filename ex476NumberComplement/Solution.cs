using System;
using System.Collections.Generic;
using System.Text;

namespace ex476NumberComplement
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            var bnum = Convert.ToString(num, 2);
            int result = 0;
            for (var i = 0; i < bnum.Length; i++) {
                var b = 1 - bnum[i] & 0x0f;
                result = b + result*2;
            }
            return result;
        }
    }
}
