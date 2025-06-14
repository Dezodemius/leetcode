using Tasks._1071._Greatest_Common_Divisor_of_Strings;

namespace _1768.MergeStringsAlternately.Tests;

public class _1071_Greatest_Common_Divisor_of_Strings_Tests
{
  [TestCase("ABCABC", "ABC", "ABC")]
  [TestCase("ABABAB", "AB", "AB")]
  [TestCase("LEET", "CODE", "")]
  [TestCase("ABABABAB", "ABAB", "ABAB")]
  public void Test(string str1, string str2, string expected)
  {
    Assert.That(new Solution().GcdOfStrings(str1, str2), Is.EqualTo(expected));
  }
}