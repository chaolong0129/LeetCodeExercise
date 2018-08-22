using System;

namespace ex653TwoSumAndBST
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var ret = solution.FindTarget(new TreeNode(5)
            {
                left = new TreeNode(3) { left = new TreeNode(2), right = new TreeNode(4) },
                right = new TreeNode(6) { right = new TreeNode(7) }
            }, 9);
            Console.WriteLine(ret);
            //var ret1 = solution.FindTarget(new TreeNode(2)
            //, 1);
            //Console.WriteLine(ret1);

            //var ret2 = solution.FindTarget(new TreeNode(2) { right = new TreeNode(3) }, 6);
            //Console.WriteLine(ret2);

            Console.ReadLine();
        }
    }
}
