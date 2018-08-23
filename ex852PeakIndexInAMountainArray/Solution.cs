using System;
using System.Collections.Generic;
using System.Text;

namespace ex852PeakIndexInAMountainArray
{
    public class Solution
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int idx = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var cMnt = A[i];
                for (int j = i+1; j < A.Length; j++)
                {
                    if (cMnt < A[j]) {
                        idx = j;
                        cMnt = A[j];
                    }
                }
            }
            return idx;
        }
    }
}
