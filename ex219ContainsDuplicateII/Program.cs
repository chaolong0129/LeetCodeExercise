using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ex219
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.Write("Input: ");
            // var input = Console.ReadLine();
            // if (!Regex.IsMatch(input, @"^[0-9]+$")){
            //     System.Console.WriteLine($"The Input({input}) is not valid format!");
            //     return;
            // }
            // System.Console.Write("K: ");
            // var k = Console.ReadLine();
            // if (String.IsNullOrEmpty(k) || !Int32.TryParse(k, out int K)) {
            //     System.Console.WriteLine($"The K is not valid!");
            //     return;
            // }

            // System.Console.WriteLine($"Input : [{input}], K : {K}");

            // int[] nums = new int[input.Length];
            // var c = input.ToCharArray();
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (Int32.TryParse(c[i].ToString(), out int o)){
            //         nums[i] = o;
            //     } else 
            //         return;
            // }

             var solution = new Solution();
            // System.Console.WriteLine(solution.ContainsNearbyDuplicate(nums, K));
            //case 1 , input[1,2,3,1,2,3], k = 2
            System.Console.WriteLine(solution.ContainsNearbyDuplicate(new int[] {1,2,3,1,2,3}, 2));
            //case 2 , input[1,0,1,1], k = 1
            System.Console.WriteLine(solution.ContainsNearbyDuplicate(new int[] {1,0,1,1}, 1));
            //case 3 , input[1,2,3,1], k = 3
            System.Console.WriteLine(solution.ContainsNearbyDuplicate(new int[] {1,2,3,1}, 3));
            //case 1 , input[1,2,3,1,2,3], k = 2
            System.Console.WriteLine(solution.ContainsNearbyDuplicate2(new int[] {1,2,3,1,2,3}, 2));
            //case 2 , input[1,0,1,1], k = 1
            System.Console.WriteLine(solution.ContainsNearbyDuplicate2(new int[] {1,0,1,1}, 1));
            //case 3 , input[1,2,3,1], k = 3
            System.Console.WriteLine(solution.ContainsNearbyDuplicate2(new int[] {1,2,3,1}, 3));

            System.Console.WriteLine(solution.ContainsNearbyDuplicate(new int[] {-1, -1}, 1));
            System.Console.WriteLine(solution.ContainsNearbyDuplicate2(new int[] {-1, -1}, 1));
        }
    }
}
