using System;
using System.Collections.Generic;

namespace ex001TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var ret = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            //var ret2 = solution.TwoSum2(new int[] { 2, 7, 11, 15 }, 9);
            var ret2 = solution.TwoSum2(new int[] { 3, 3}, 6);
            foreach (var n in ret)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            foreach (var n in ret2)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
