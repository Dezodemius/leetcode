namespace Tasks.Task605;

public class Solution
{
  public bool CanPlaceFlowers(int[] flowerbed, int n)
  {
    var k = 0;

    for (int i = 0; i < flowerbed.Length; i++)
    {
      if (flowerbed[i] == 1)
      {
        i++;
        continue;
      }

      if (flowerbed[i] == 0)
      {
        if (i == flowerbed.Length - 1 && flowerbed[i] == 0)
        {
          k++;
          continue;
        }
        if (i < flowerbed.Length && flowerbed[i + 1] == 0)
        {
          k++;
          i++;
        }
      }
    }

    return n <= k;
  }
}