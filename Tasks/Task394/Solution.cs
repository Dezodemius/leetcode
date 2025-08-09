using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task394;

public class Solution
{
  public string DecodeString(string s)
  {
    var currentString = string.Empty;
    var currentNumber = string.Empty;
    var strings = new Stack<string>();
    var counts = new Stack<int>();

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
      else if (c == '[')
      {
        counts.Push(int.Parse(currentNumber));
        strings.Push(currentString);
        currentNumber = string.Empty;
        currentString = string.Empty;
      }
      else if (c == ']')
      {
        var count = counts.Pop();
        var temp = string.Empty;
        for (var i = 0; i < count; i++)
          temp += currentString;
        currentString = strings.Pop() + temp;
      }
    }
    
    return currentString;
  }
}