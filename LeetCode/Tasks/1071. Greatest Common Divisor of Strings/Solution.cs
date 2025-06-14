using System.Text;

namespace Tasks._1071._Greatest_Common_Divisor_of_Strings;

public class Solution {
  public string GcdOfStrings(string str1, string str2) {
    if (str1.Length >= str2.Length)
    {
      for (int i = 0; i < str2.Length; i++)
      {
        var divider = str2.Substring(0, str2.Length - i);
        if (IsDivider(str1, divider) && IsDivider(str2, divider))
          return divider;
      }
    }
    else
    {
      for (int i = 0; i < str1.Length; i++)
      {
        var divider = str1.Substring(0, str1.Length - i);
        if (IsDivider(str1, divider) && IsDivider(str2, divider))
          return divider;
      }
    }
    return string.Empty;
  }

  private bool IsDivider(string str, string divider)
  {
    return str.Replace(divider, string.Empty).Length == 0;
  }
}