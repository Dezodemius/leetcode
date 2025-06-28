namespace Tasks.Task1732;

public class Solution
{
  public int LargestAltitude(int[] gain)
  {
    var point = 0;
    var max = 0;
    for (int i = 0; i < gain.Length; i++)
    {
      point += gain[i];
      if (point > max)
        max = point;
    }
    return max;
  }
}