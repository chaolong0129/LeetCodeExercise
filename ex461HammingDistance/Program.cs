using System;

namespace ex461HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.HammingDistance(1, 2));
            Console.WriteLine(solution.HammingDistance(1, 4));
            Console.ReadLine();
        }
    }
}
