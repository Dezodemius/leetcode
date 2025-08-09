using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task394;

public class Solution
{
  public string DecodeString(string s) {
    string res = string.Empty;
    var numbers = new Stack<int>();
    var chars = new Stack<string>();

    var currentString = string.Empty;
    var currentNumber = string.Empty;

    foreach (var c in s)
    {
      if (c == '[')
      {
        chars.Push(currentString);
        numbers.Push(int.Parse(currentNumber));
        currentString = string.Empty;
        currentNumber = string.Empty;
      }
      else if (c == ']')
      {
        var length = numbers.Pop();
        for (int i = 0; i < length - 1; i++)
          currentString += currentString;
        // chars.Push(chars.Pop() + res);
        currentString = chars.Pop() + res;
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

    return res + currentString;
  }
}