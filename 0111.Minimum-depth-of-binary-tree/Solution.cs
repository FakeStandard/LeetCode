﻿using Common;
using System;

namespace _0111.Minimum_depth_of_binary_tree
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            if (root.left == null)
                return MinDepth(root.right) + 1;

            if (root.right == null)
                return MinDepth(root.left) + 1;

            int l = MinDepth(root.left) + 1;
            int r = MinDepth(root.right) + 1;

            return l > r ? r : l;
        }
    }
}
