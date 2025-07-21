using System.Collections.Generic;

namespace Tasks.Task13;

public class Solution {
    private static readonly Dictionary<char, int> romanIntMap = new()
    {
      { 'I', 1 },
      { 'V', 5 },
      { 'X', 10 },
      { 'L', 50 },
      { 'C', 100 },
      { 'D', 500 },
      { 'M', 1000 },
    };
    public int RomanToInt(string s) {
       var result = 0;
      for (int i = 0; i < s.Length; i++)
      {
        if (i + 1 < s.Length && romanIntMap[s[i]] < romanIntMap[s[i + 1]])
        {
          result -= romanIntMap[s[i]];
        }
        else
          result += romanIntMap[s[i]];
      }
      return result;
    }
}