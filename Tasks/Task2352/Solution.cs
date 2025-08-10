using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task2352;

public class Solution
{
  public int EqualPairs(int[][] grid)
  {
    int result = 0;
    var dic = new Dictionary<string, int>();
    foreach (var item in grid)
    {
      var s = string.Join(",", item);
      dic.TryAdd(s, 0);
      dic[s]++;
    }

    for (int j = 0; j < grid.Length; j++) {
      List<int> colList = new List<int>();
      for (int i = 0; i < grid.Length; i++) {
        colList.Add(grid[i][j]);
      }
      string colKey = string.Join(",", colList);
      if (dic.TryGetValue(colKey, out var value)) {
        result += value;
      }
    }
    return result;
  }
}