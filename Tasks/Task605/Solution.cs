namespace Tasks.Task605;

public class Solution
{
  public bool CanPlaceFlowers(int[] flowerbed, int n)
  {
    Dictionary<int, bool> array = new Dictionary<int, bool>(flowerbed.Length);
    var k = flowerbed.Length;
    int i = 1;
    array[0] = false;
    if (flowerbed[0] == 1)
    {
      k -= 2;
      array[0] = true;
      array[1] = true;
      i = 2;
    }

    for (; i < flowerbed.Length; i++)
    {
      array[i] = false;
      if (flowerbed[i] == 1)
      {
        if (array.TryGetValue(i - 1, out bool result) && result == false)
        {
          k -= 2;
          array[i] = true;
          array[i - 1] = true;
        }
        else
        {
          k--;
          array[i] = true;
        }
        if (i != flowerbed.Length - 1)
        {
          k--;
          array[i + 1] = true;
          i++;
        }
      }
    }

    return n <= (k % 2 == 0 ? k / 2 : k / 2 + 1);
  }
}