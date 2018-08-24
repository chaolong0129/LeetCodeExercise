using System;

namespace ex476NumberComplement
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.FindComplement(5));
            Console.WriteLine(solution.FindComplement(1));
            Console.WriteLine(solution.FindComplement(2));
            Console.ReadLine();
        }
    }
}
