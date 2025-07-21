namespace Tasks.Task1523;

public class Solution {
  public int CountOdds(int l, int h) {
    var i = h - l + 1;
    return (l % 2 == 0) ? i / 2 : (i + 1) / 2;
  }
}