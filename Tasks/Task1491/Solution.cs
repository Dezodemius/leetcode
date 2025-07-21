using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task1491;

public class Solution {
  public double Average(int[] salary) {
    Array.Sort(salary);
    var list = new List<int>(salary);
    list.Remove(list[^1]);
    list.Remove(list[0]);
    return list.Average();
  }
}