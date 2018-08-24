using System;

namespace ex342PowerOfFour
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.IsPowerOfFourWithLoop(16));
            Console.WriteLine(solution.IsPowerOfFourWithLoop(3));
            Console.WriteLine(solution.IsPowerOfFourWithLoop(2));
            Console.WriteLine(solution.IsPowerOfFourWithRecursive(16));
            Console.WriteLine(solution.IsPowerOfFourWithRecursive(3));
            Console.WriteLine(solution.IsPowerOfFourWithRecursive(2));
            Console.WriteLine(solution.IsPowerOfFourWithRecursive2(16));
            Console.WriteLine(solution.IsPowerOfFourWithRecursive2(3));
            Console.WriteLine(solution.IsPowerOfFourWithRecursive2(2));
            Console.WriteLine(solution.IsPowerOfFour(16));
            Console.WriteLine(solution.IsPowerOfFour(3));
            Console.WriteLine(solution.IsPowerOfFour(2));
            Console.ReadLine();
        }
    }
}
