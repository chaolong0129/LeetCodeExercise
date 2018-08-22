using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex001TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length -1; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target) {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("Not Found!");
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dict.ContainsValue(complement))
                {
                    var key = dict.FirstOrDefault(k => k.Value == complement).Key;
                    if (key != i)
                        return new int[] { key, i };
                }
                dict.Add(i, nums[i]);
            }
            
            throw new Exception("Not Found!");
        }
    }
}
