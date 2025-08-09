using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task394;

public class Solution
{
  public string DecodeString(string s) {
    string res = string.Empty;
    var numbers = new Stack<char>(s);
    var chars = new Stack<char>(s);

    var currentString = string.Empty;
    var currentNumber = string.Empty;

    foreach (var c in s)
    {
      if (c == '[')
      {
        currentString = string.Empty;
        
      }
      else if (c == ']')
      {
        for (int i = 0; i < int.Parse(currentNumber); i++)
          res += currentString;
        currentString = string.Empty;
        currentNumber = string.Empty;
      }
      else if (char.IsNumber(c))
      {
        currentNumber += c.ToString();
      }
      else
      {
        currentString += c;
      }
    }

    return res +  currentString;
  }
}