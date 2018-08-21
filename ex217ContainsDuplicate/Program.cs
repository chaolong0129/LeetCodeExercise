using System;

namespace ex217ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            System.Console.WriteLine(solution.ContainsDuplicate(new int[]{1,2,3,1}));
            System.Console.WriteLine(solution.ContainsDuplicate(new int[]{1,2,3,4}));
            System.Console.WriteLine(solution.ContainsDuplicate(new int[]{1,1,1,3,3,4,3,2,4,2}));
            System.Console.WriteLine(solution.ContainsDuplicate2(new int[]{1,2,3,1}));
            System.Console.WriteLine(solution.ContainsDuplicate2(new int[]{1,2,3,4}));
            System.Console.WriteLine(solution.ContainsDuplicate2(new int[]{1,1,1,3,3,4,3,2,4,2}));
        }
    }
}
