using System;
using System.Collections.Generic;
using System.Text;

namespace ex190ReverseBits
{
    public class Solution
    {
        // Use operator >>, << to do shift and use & operator to got vlaue;
        public uint reverseBits(uint n)
        {
            uint ret = 0;
            for (int i = 0; i < 32; i++)
            {
                var iBits = (n >> i) & 1;
                ret = (ret << 1) + iBits;
            }
            return ret;
        }
    }
}
