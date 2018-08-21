using System;
using System.Collections.Generic;
using System.Text;

namespace ex220ContainsDuplicateIII
{
    public class Solution
    {
        /*
         * Condition : Abs(i - j) < k && Abs(num[i] - num[j]) < t
         */
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            var bucket = new Dictionary<long, long>();

            if (t < 0 || k < 0 || nums.Length <= 0) return false;

            for (int i = 0; i < nums.Length; i++)
            {
                var bucketIndex = ((long)nums[i] - Int32.MinValue) / ((long)t + 1);
                if (i - k - 1 >= 0) {
                    bucket.Remove(((long)nums[i - k -1] - Int32.MinValue)/((long)t+1));
                }

                if (bucket.ContainsKey(bucketIndex)
                    || bucket.ContainsKey(bucketIndex - 1) && nums[i] - bucket[bucketIndex - 1] <= t
                    || bucket.ContainsKey(bucketIndex + 1) && bucket[bucketIndex + 1] - nums[i] <= t
                    )
                    return true;
                bucket[bucketIndex] = nums[i];
            }
            return false;
        }
    }
}
