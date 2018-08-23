using System;
using System.Collections.Generic;
using System.Text;

namespace ex657JudgeRouteCircle
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;

            foreach (var m in moves)
            {
                switch (m) {
                    case 'U': y++; break;
                    case 'D': y--; break;
                    case 'R': x++; break;
                    case 'L': x--; break;
                    default:break;
                }
            }

            return (x == 0 && y == 0);
        }
    }
}
