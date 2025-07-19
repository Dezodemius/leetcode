using System.Text;

namespace Tasks.Task443;

public class Solution
{
  public int Compress(char[] chars)
  {
    var res = new StringBuilder();
    var groupStartSymbol = chars[0];
    var count = 1;
    for (int i = 1; i < chars.Length; i++)
    {
      if (groupStartSymbol == chars[i])
      {
        count++;
      }
      else
      {
        res.Append(groupStartSymbol.ToString());
        groupStartSymbol = chars[i];
        if (count == 1)
          continue;
        res.Append(count.ToString());
        count = 1;
      }
    }

    if (count != 1)
      res.Append(groupStartSymbol.ToString() + count);
    else
      res.Append(groupStartSymbol.ToString());
    for (int i = 1; i < res.Length; i++)
    {
      chars[i] = res[i];
    }

    return res.Length;
  }
}