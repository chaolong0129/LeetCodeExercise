using System;
using System.Collections.Generic;
using System.Text;

namespace ex653TwoSumAndBST
{
    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int x) { val = x; }
    * }
    */
    public class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var list = new List<int>();

            BST2LSTMID(root, list);
            list.Sort();
            if (list.Count < 2) return false;

            for (int i = 0; i < list.Count; i++)
            {
                int complement = k - list[i];
                if (list.Contains(complement) && list[i] != complement) return true;
                continue;
            }
            return false;
        }

        //post-order
        private void BST2LSTPOST(TreeNode root, List<int> list)
        {
            if (root.left != null) BST2LSTPOST(root.left, list);
            if (root.right != null) BST2LSTPOST(root.right, list);
            if (root != null)
                list.Add(root.val);
        }

        //pre-order
        private void BST2LSTPRE(TreeNode root, List<int> list)
        {
            if (root != null)
                list.Add(root.val);
            if (root.left != null) BST2LSTPRE(root.left, list);
            if (root.right != null) BST2LSTPRE(root.right, list);
        }

        // mid-order
        private void BST2LSTMID(TreeNode root, List<int> list)
        {
            if (root.left != null) BST2LSTMID(root.left, list);
            if (root != null)
                list.Add(root.val);
            if (root.right != null) BST2LSTMID(root.right, list);
        }
    }
}
