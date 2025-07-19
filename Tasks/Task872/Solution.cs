using System.Collections.Generic;
using System.Linq;
using TaskUtils;

namespace Tasks.Task872;

public class Solution
{
  public bool LeafSimilar(TreeNode root1, TreeNode root2)
  {
    var leftLeaves = new List<int>();
    var rightLeaves = new List<int>();
    LeafCollector(root1, leftLeaves);
    LeafCollector(root2, rightLeaves);

    return rightLeaves.SequenceEqual(leftLeaves);
  }

  private void LeafCollector(TreeNode root, List<int> nodes)
  {
    if (root == null)
      return;
    if (root.left == null && root.right == null)
      nodes.Add(root.val);

    LeafCollector(root.left, nodes);
    LeafCollector(root.right, nodes);
  }
}