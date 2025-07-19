namespace TaskUtils;

public static class TreeNodeBuilder
{
  public static TreeNode BuildTreeFromArray(int[] arr)
  {
    if (arr.Length == 0)
      return null;

    TreeNode root = new TreeNode(arr[0]);
    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);

    int i = 1;
    while (queue.Count > 0 && i < arr.Length)
    {
      TreeNode current = queue.Dequeue();

      if (i < arr.Length && arr[i] != null && arr[i] != int.MinValue)
      {
        current.left = new TreeNode(arr[i]);
        queue.Enqueue(current.left);
      }
      i++;

      if (i < arr.Length && arr[i] != null && arr[i] != int.MinValue)
      {
        current.right = new TreeNode(arr[i]);
        queue.Enqueue(current.right);
      }
      i++;
    }

    return root;
  }

  public static int[] BuildArrayFromTreeNode(TreeNode root)
  {
    if (root == null)
      return [];

    var result = new List<int>();
    var queue = new Queue<TreeNode>();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
      int levelSize = queue.Count;
      bool levelHasValues = false;
      var levelNodes = new List<int>();

      for (int i = 0; i < levelSize; i++)
      {
        var node = queue.Dequeue();

        if (node != null)
        {
          levelNodes.Add(node.val);
          queue.Enqueue(node.left ?? null);
          queue.Enqueue(node.right ?? null);
          if (node.left != null || node.right != null)
            levelHasValues = true;
        }
        else
        {
          levelNodes.Add(int.MinValue);
          queue.Enqueue(null);
          queue.Enqueue(null);
        }
      }

      if (!levelHasValues && levelNodes.All(x => x == int.MinValue))
        break;

      result.AddRange(levelNodes);
    }

    int lastNonNullIndex = result.FindLastIndex(x => x != int.MinValue);
    if (lastNonNullIndex >= 0)
      return result.GetRange(0, lastNonNullIndex + 1).ToArray();

    return [];
  }
}