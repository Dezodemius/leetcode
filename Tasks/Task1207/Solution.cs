namespace Tasks.Task1207;

public class Solution
{
  public bool UniqueOccurrences(int[] arr) {
    var a = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
      if (a.ContainsKey(arr[i]))
        a[arr[i]]++;
      else
        a[arr[i]] = 1;
    }

    return a.Values.Count == a.Values.Distinct().Count();
  }
}