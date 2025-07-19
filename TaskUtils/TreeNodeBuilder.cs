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
}