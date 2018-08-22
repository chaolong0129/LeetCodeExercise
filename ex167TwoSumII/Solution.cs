using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex167TwoSumII
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int f = 0, l = numbers.Length - 1;
            while (f < l) {
                int sum = numbers[f] + numbers[l];
                if (sum == target) return new int[] { f + 1, l + 1 };
                else if (sum < target) ++f;
                else --l;
            }
            throw new Exception("Not found!");
        }
    }
}
