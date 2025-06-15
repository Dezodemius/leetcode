using System.Text;

namespace Tasks.Task345;

public class Solution
{
  public string ReverseVowels(string s) {
    StringBuilder list = new StringBuilder();
    for (int i = 0; i < s.Length; i++)
    {
      if (IsVowel(s[i]))
        list.Append(s[i]);
    }

    var k = 1;
    StringBuilder result = new StringBuilder();
    for (int i = 0; i < s.Length; i++)
    {
      if (IsVowel(s[i]))
      {
        result.Append(list[^k]);
        k++;
      }
      else
        result.Append(s[i]);
    }
    return result.ToString();
  }
  public static bool IsVowel(char c)
  {
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
           || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
  }
}