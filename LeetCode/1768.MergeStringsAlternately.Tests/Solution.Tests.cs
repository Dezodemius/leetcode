namespace _1768.MergeStringsAlternately.Tests;

public class Tests
{
  [TestCase("abc", "def", "adbecf")]
  [TestCase("ab", "pqrs", "apbqrs")]
  [TestCase("abcd", "pq", "apbqcd")]
  public void Test1(string word1, string word2, string expected)
  {
    Assert.That(new Solution().MergeAlternately(word1, word2),
      Is.EqualTo(expected));
  }
}