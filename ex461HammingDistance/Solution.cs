using System;
using System.Collections.Generic;
using System.Text;

namespace ex461HammingDistance
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            var numX = Convert.ToString(x, 2);
            var numY = Convert.ToString(y, 2);
            if (x > y)
                MakeUpLen(numY.Length, numX.Length, ref numY);
            else if (x < y)
                MakeUpLen(numX.Length, numY.Length, ref numX);
            return Comp(numX, numY);
        }

        private static int Comp(string numX, string numY)
        {
            int ans = 0;

            for (int i = 0; i < numX.Length; i++)
            {
                if (numX[i] != numY[i])
                    ans++;
            }

            return ans;
        }

        public void MakeUpLen(int s, int e, ref string str)
        {
            for (int i = s; i < e; i++)
            {
                str = "0" + str;
            }
        }
    }
}
