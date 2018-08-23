using System;
using System.Collections.Generic;
using System.Text;

namespace ex832FlippingAnImage
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int m = A.Length, n = A[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n/2; j++)
                    swap(ref A[i][j], ref A[i][n - j -1]);
                for (int j = 0; j < n; j++)
                    A[i][j] = A[i][j] ^ 1;
            }
            return A;
        }

        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
