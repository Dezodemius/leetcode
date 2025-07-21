using System.Linq;

namespace Tasks.Task1491;

public class Solution {
  public double Average(int[] salary) {
    var max = salary.Max();
    var min = salary.Min();
    return (salary.Sum() - (max + min)) / (double)(salary.Count() - 2);
  }
}