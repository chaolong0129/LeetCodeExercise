using System;
using System.Collections.Generic;
using System.Text;

namespace ex371SumOfTwoIntegers
{
    public class Solution
    {
        public int GetSum(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            int sum = a ^ b;
            int carry = (a & b) << 1;

            return GetSum(sum, carry);
        }
    }
}
