using System;

namespace ex709ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "HelloWorld";
            var solution = new Solution();
            Console.WriteLine(solution.ToLowerCase(str));
            Console.ReadLine();
        }
    }
}
