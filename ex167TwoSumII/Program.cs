using System;

namespace ex167TwoSumII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var ret = solution.TwoSum(new int[] { 2, 7, 1, 3 }, 9);
            foreach (var idx in ret)
            {
                Console.Write($"{idx} ");
            }
            Console.ReadLine();
        }
    }
}
