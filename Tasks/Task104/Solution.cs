using System;
using TaskUtils;

namespace Tasks.Task104;

public class Solution
{
  public int MaxDepth(TreeNode root) {
    if (root == null)
      return 0;
    var left_depth = MaxDepth(root.left);
    var right_depth = MaxDepth(root.right);

    return 1 + Math.Max(left_depth, right_depth);
  }
}