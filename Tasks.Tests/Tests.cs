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

  [TestCase(new[] {2,3,5,1,3}, 3, new[] {true,true,true,false,true})]
  [TestCase(new[] {4,2,1,1,2}, 1, new[] {true,false,false,false,false})]
  [TestCase(new[] {12,1,12}, 10, new[] {true,false,true})]
  public void Test1431(int[] flowerbed, int n, bool[] expected)
  {
    Assert.That(new Task1431.Solution().KidsWithCandies(flowerbed, n), Is.EqualTo(expected));
  }

  #endregion

  #region Task605

  [TestCase(new[] {1,0,0,0,1}, 2, false)]
  [TestCase(new[] {1,0,0,0,1}, 1, true)]
  [TestCase(new[] {0,1,0,0,1}, 1, false)]
  [TestCase(new[] {0,0,1,0,1}, 1, true)]
  [TestCase(new[] {0,0,0,0,1}, 1, true)]
  [TestCase(new[] {0,0,0,0,1}, 2, true)]
  [TestCase(new[] {1,0,0,0,0,1}, 2, false)]
  [TestCase(new[] {1,0,0,0,0,0,1}, 2, true)]
  [TestCase(new[] {1,0,0,0,1,0,0}, 2, true)]
  public void Test605(int[] flowerbed, int n, bool expected)
  {
    Assert.That(new Task605.Solution().CanPlaceFlowers(flowerbed, n), Is.EqualTo(expected));
  }

  #endregion

  #region Task345

  [TestCase("IceCreAm", "AceCreIm")]
  [TestCase("leetcode", "leotcede")]
  public void Test345(string s, string expected)
  {
    Assert.That(new Task345.Solution().ReverseVowels(s), Is.EqualTo(expected));
  }

  #endregion

  #region Task151

  [TestCase("the sky is blue", "blue is sky the")]
  [TestCase("  hello world  ", "world hello")]
  [TestCase("a good   example", "example good a")]
  public void Test151(string s, string expected)
  {
    Assert.That(new Task151.Solution().ReverseWords(s), Is.EqualTo(expected));
  }

  #endregion

  #region Task643

  [TestCase(new[] {1,12,-5,-6,50,3}, 6, 9.16666d)]
  [TestCase(new[] {1,12,-5,-6,50,3}, 4, 12.75000d)]
  [TestCase(new[] {5}, 1, 5.00000d)]
  [TestCase(new[] {0,1,1,3,3}, 4, 2.00000d)]  
  public void Test643(int[] nums, int k, double expected)
  {
    var actual = new Task643.Solution().FindMaxAverage(nums, k);
    Assert.That(actual - expected, Is.LessThanOrEqualTo(10e-5));
  }

  #endregion

  #region Task283

  [TestCase(new int[] {0,1,0,3,12}, new int[] {1,3,12,0,0})]
  [TestCase(new int[] {0,0,1}, new int[] {1,0,0})]
  public void Test283(int[] nums, int[] expected)
  {
    new Task283.Solution().MoveZeroes(nums);
    Assert.That(expected, Is.EqualTo(nums));
  }

  #endregion

  #region Task392

  [TestCase("abc", "ahbgdc", true)]
  [TestCase("axc", "ahbgdc", false)]
  [TestCase("", "ahbgdc", true)]
  [TestCase("b", "abc", true)]
  public void Test392(string s, string t, bool expected)
  {
    Assert.That(new Task392.Solution().IsSubsequence(s, t), Is.EqualTo(expected));
  }

  #endregion
}