using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task2390;

public class Solution
{
  public string RemoveStars(string s) {
    var stack = new Stack<char>();
    var result = "";

    foreach (var c in s)
    {
      if (c == '*')
        stack.Pop();
      else
      {
        stack.Push(c);
      }
    }

    return string.Join(string.Empty, stack.Reverse());
  }
}