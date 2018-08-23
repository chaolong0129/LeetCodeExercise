using System;
using System.Collections.Generic;
using System.Text;

namespace ex226InvertBinaryTree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            var l = root.left;
            var r = root.right;
            root.left = InvertTree(r);
            root.right = InvertTree(l);
            return root;
        }
    }
}
