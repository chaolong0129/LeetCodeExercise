using System;
using System.Collections.Generic;

namespace ex219 {
    public class Solution {
        public bool ContainsNearbyDuplicate (int[] nums, int k) {
            var hashSet = new HashSet<int> ();
            for (int i = 0; i < nums.Length; i++) {
                if (i > k)
                    hashSet.Remove (nums[i - k - 1]);
                if (!hashSet.Add (nums[i]))
                    return true;
            }
            return false;
        }
        public bool ContainsNearbyDuplicate2 (int[] nums, int k) {
            Dictionary<int, int> dict = new Dictionary<int, int> ();
            for (int i = 0; i < nums.Length; i++) {
                if (dict.TryGetValue(nums[i], out int j)) {
                    if (Math.Abs (i - j) <= k)
                        return true;
                    dict.Remove (nums[i]);
                    dict.Add (nums[i], i);
                    continue;
                }
                dict.Add (nums[i], i);
            }
            return false;
        }
    }
}