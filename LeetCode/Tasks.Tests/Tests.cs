namespace Tasks;

public class Tests
{
  #region Task1768
  [TestCase("abc", "def", "adbecf")]
  [TestCase("ab", "pqrs", "apbqrs")]
  [TestCase("abcd", "pq", "apbqcd")]
  public void Test1768(string word1, string word2, string expected)
  {
    Assert.That(new Task1768.Solution().MergeAlternately(word1, word2),
      Is.EqualTo(expected));
  }

  #endregion

  #region Task1071

  [TestCase("ABCABC", "ABC", "ABC")]
  [TestCase("ABABAB", "AB", "AB")]
  [TestCase("LEET", "CODE", "")]
  [TestCase("ABABABAB", "ABAB", "ABAB")]
  public void Test1071(string str1, string str2, string expected)
  {
    Assert.That(new Task1071.Solution().GcdOfStrings(str1, str2), Is.EqualTo(expected));
  }

  #endregion

}