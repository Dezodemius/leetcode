using System.Collections.Generic;

namespace Tasks.Task17;

public class Solution
{
  private IList<string> result = new List<string>();

  private Dictionary<char, string> keyboard = new Dictionary<char, string>
  {
    {'2', "abc"},
    {'3', "def"},
    {'4', "ghi"},
    {'5', "jkl"},
    {'6', "mno"},
    {'7', "pqrs"},
    {'8', "tuv"},
    {'9', "wxyz"},
  };

  public IList<string> LetterCombinations(string digits)
  {
    if (string.IsNullOrEmpty(digits))
      return result;
    Bactracking("", digits);
    return this.result;
  }

  private void Bactracking(string combination, string nextDigits)
  {
    if (string.IsNullOrEmpty(nextDigits))
      this.result.Add(combination);
    else
    {
      foreach (char letter in keyboard[nextDigits[0]])
        Bactracking(combination + letter, nextDigits.Substring(1));
    }
  }
}