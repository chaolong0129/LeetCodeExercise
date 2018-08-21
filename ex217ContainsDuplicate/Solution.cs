using System;
using System.Collections.Generic;
using System.Linq;

namespace ex217ContainsDuplicate {
    public class Solution {
        public bool ContainsDuplicate (int[] nums) {
            var ns = (from n in nums orderby n ascending select n).ToArray ();
            //var ns = nums.OrderBy(n => n).Select (n => n).ToArray();
            int count = 0;
            for (int i = 0; i < ns.Length && count < 2; i++) {
                count = 0;
                for (int j = i; j < ns.Length && count < 2; j++) {
                    if (ns[i] == ns[j])
                        count++;
                }
            }
            return (count > 1);
        }

        public bool ContainsDuplicate2 (int[] nums) {
            var hashSet = new HashSet<int> ();
            foreach (var n in nums) {
                if (hashSet.Contains (n))
                    return true;
                hashSet.Add (n);
            }
            return false;
        }
    }
}