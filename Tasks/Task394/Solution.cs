using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task394;

public class Solution
{
  public string DecodeString(string s)
  {
    var res = string.Empty;
    var currentString = string.Empty;
    var currentNumber = string.Empty;

    foreach (var c in s)
    {
      if (char.IsDigit(c))
      {
        currentNumber += c.ToString();
      }
      else if (char.IsLetter(c))
      {
        currentString += c.ToString();
      }
      // else if (c == '[')
      // {
      //   
      // }
      else if (c == ']')
      {
        var count = int.Parse(currentNumber);
        for (var i = 0; i < count; i++)
          res += currentString;
        currentString = string.Empty;
        currentNumber = string.Empty;
      }
    }
    
    return res + currentString;
  }
}