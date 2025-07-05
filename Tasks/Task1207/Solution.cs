using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task1207;

public class Solution
{
  public bool UniqueOccurrences(int[] arr) {
    var a = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
      if (!a.TryAdd(arr[i], 1))
        a[arr[i]]++;
    }

    return a.Values.Count == a.Values.Distinct().Count();
  }
}