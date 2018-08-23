using System;
using System.Collections.Generic;
using System.Text;

namespace ex007ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int ret = 0;
            while (x != 0) {
                var val = x % 10;
                var t = ret * 10 + val;
                // To Valify the value is or not overflow.
                if ((t - val) / 10 != ret) return 0;
                ret = t;
                x = x / 10;
            }
            return ret;
        }
    }
}
