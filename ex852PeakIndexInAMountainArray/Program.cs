using System;

namespace ex852PeakIndexInAMountainArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.PeakIndexInMountainArray(new int[] { 0, 1, 0}));
            Console.WriteLine(solution.PeakIndexInMountainArray(new int[] { 0, 2, 1, 0 }));
            Console.WriteLine(solution.PeakIndexInMountainArray2(new int[] { 0, 1, 0 }));
            Console.WriteLine(solution.PeakIndexInMountainArray2(new int[] { 0, 2, 1, 0 }));
            Console.ReadLine();
        }
    }
}
