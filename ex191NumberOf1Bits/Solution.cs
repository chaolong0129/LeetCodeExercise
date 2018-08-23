using System;
using System.Collections.Generic;
using System.Text;

namespace ex191NumberOf1Bits
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            var nstr = Convert.ToString(n, 2);
            int dist = 0;
            foreach (var d in nstr)
                if (d == '1') dist++;
            return dist;
        }
    }
}
