using System;
using System.Collections.Generic;
using System.Text;

namespace ex342PowerOfFour
{
    public class Solution
    {
        // Loop
        public bool IsPowerOfFourWithLoop(int num)
        {
            while (num != 0 && (num % 4 == 0))
                num /= 4;
            return num == 1;
        }

        // Recursive
        public bool IsPowerOfFourWithRecursive(int num)
        {
            if (num != 0 && num % 4 == 0)
                IsPowerOfFourWithRecursive(num /= 4);
            if (num >= 4)
                IsPowerOfFourWithRecursive(num /= 4);
            return (num == 1);
        }

        public bool IsPowerOfFourWithRecursive2(int num)
        {
            if (num > 4)
            {
                num = (num >> 2) / 4;
                IsPowerOfFour(num);
            } 

            return num == 1;
        }

        public bool IsPowerOfFour(int num)
        {
            return num > 0 && (num & (num - 1)) == 0 && (num & 0x55555555) != 0;
        }
    }
}
