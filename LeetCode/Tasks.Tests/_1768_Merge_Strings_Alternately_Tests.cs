using Tasks._1768._Merge_Strings_Alternately;

namespace _1768.MergeStringsAlternately.Tests;

public class _1768_Merge_Strings_Alternately_Tests
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