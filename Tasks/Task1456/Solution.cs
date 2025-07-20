namespace Tasks.Task1456;

public class Solution
{
  public int MaxVowels(string s, int k)
  {
    var array = s.ToCharArray();
    if (k > array.Length)
      return 0;

    var res = 0;

    for (int i = 0; i < k; i++)
    {
      if (IsVowel(array[i]))
        res++;
    }
    if (res == k)
      return res;

    var tempRes = res;
    for (int i = 1; i < array.Length - k + 1; i++)
    {
      if (IsVowel(array[i - 1]))
        tempRes--;
      if (IsVowel(array[i + k - 1]))
        tempRes++;
      if (tempRes > res)
        res = tempRes;
      if (res == k)
        return res;
    }

    return res;
  }

  private static bool IsVowel(char x)
  {
    return x is 'a' or 'e' or 'i' or 'o' or 'u';
  }
}