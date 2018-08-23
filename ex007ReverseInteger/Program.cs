using System;

namespace ex007ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.Reverse(123));
            Console.WriteLine(solution.Reverse(-123));
            Console.ReadLine();
        }
    }
}
