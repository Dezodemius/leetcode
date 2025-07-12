using System.Text;

namespace Tasks.Task443;

public class Solution
{
  public int Compress(char[] chars)
  {
    char prev = chars[0];
    int num = 1;
    var str = new StringBuilder();
    str.Append(chars[0]);

    for (int i = 1; i < chars.Length; i++)
    {
      if (chars[i] == prev)
      {
        num++;
      }
      if (chars[i] != prev || i == chars.Length - 1)
      {
        prev = chars[i];
        if (num > 1)
        {
          var nums_s = num.ToString();
          foreach (var t in nums_s)
          {
            str.Append(t);
          }
        }

        if (i == chars.Length - 1)
        {
          if (num == 1)
            str.Append(chars[i]);
          break;
        }

        num = 1;
      }
    }

    var k = 0;
    for (int i = 0; i < chars.Length; i++)
    {
      if (k < str.Length)
        chars[i] = str[k];
      else
        chars[i] = '\0';
      k++;
    }

    return str.Length;
  }
}