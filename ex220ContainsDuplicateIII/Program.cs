using System;

namespace ex220ContainsDuplicateIII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.ContainsNearbyAlmostDuplicate(new int[]{ 1, 2, 3, 1}, 3, 0));
            Console.WriteLine(solution.ContainsNearbyAlmostDuplicate(new int[]{ 1, 0, 1, 1}, 1, 2));
            Console.WriteLine(solution.ContainsNearbyAlmostDuplicate(new int[]{ 1, 5, 9, 1, 5, 9}, 2, 3));
            Console.ReadLine();   
        }
    }
}
