using TaskUtils;

namespace Tasks.Task700;

public class Solution {
  public TreeNode SearchBST(TreeNode root, int val)
  {
    if (root == null)
      return null;

    if (root.val == val)
      return root;

    if (root.val > val && root.left != null)
      return SearchBST(root.left, val);
    if (root.val < val && root.right != null)
      return SearchBST(root.right, val);

    return null;
  }
}