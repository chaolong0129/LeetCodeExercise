using System;

namespace ex191NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.HammingWeight(11));
            Console.WriteLine(solution.HammingWeight(128));
            Console.ReadLine();
        }
    }
}
