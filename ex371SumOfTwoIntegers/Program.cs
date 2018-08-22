using System;

namespace ex371SumOfTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.GetSum(1, 2));
            Console.WriteLine(solution.GetSum(-1, -1));

            Console.ReadLine();
        }
    }
}
