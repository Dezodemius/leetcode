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

  #region Task1431

  [TestCase(new int[] {2,3,5,1,3}, 3, new bool[] {true,true,true,false,true})]
  [TestCase(new int[] {4,2,1,1,2}, 1, new bool[] {true,false,false,false,false})]
  [TestCase(new int[] {12,1,12}, 10, new bool[] {true,false,true})]
  public void Test1431(int[] candies, int extraCandies, bool[] expected)
  {
    Assert.That(new Task1431.Solution().KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
  }

  #endregion
}