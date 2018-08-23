using System;

namespace ex226InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode(4) {
                left = new TreeNode(2) {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7) {
                    left = new TreeNode(6),
                    right = new TreeNode(9)
                }
            };
            var solution = new Solution();
            solution.InvertTree(tree);
        }
    }
}
