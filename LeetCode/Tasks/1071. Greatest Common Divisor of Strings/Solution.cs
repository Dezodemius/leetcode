using System.Text;

namespace Tasks._1071._Greatest_Common_Divisor_of_Strings;

public class Solution {
  public string GcdOfStrings(string str1, string str2) {
    if (str1 + str2 != str2 + str1)
      return string.Empty;

    var l1 = str1.Length;
    var l2 = str2.Length;

    while (l2 > 0)
    {
      var temp = l2;
      l2 = l1 % l2;
      l1 = temp;
    }

    return str1.Substring(0, l1);
  }
}