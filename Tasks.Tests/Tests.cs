using System;
using System.Collections.Generic;
using Tasks.Task933;
using TaskUtils;

namespace Tasks.Tests;

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

  [TestCase(new[] {0,1,0,3,12}, new[] {1,3,12,0,0})]
  [TestCase(new[] {0,0,1}, new[] {1,0,0})]
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
  [TestCase("b", "c", false)]
  public void Test392(string s, string t, bool expected)
  {
    Assert.That(new Task392.Solution().IsSubsequence(s, t), Is.EqualTo(expected));
  }

  #endregion

  #region Task1732

  [TestCase(new[] {-5,1,5,0,-7}, 1)]
  [TestCase(new[] {-4,-3,-2,-1,4,3,2}, 0)]
  public void Test1732(int[] gain, int expected)
  {
    Assert.That(new Task1732.Solution().LargestAltitude(gain), Is.EqualTo(expected));
  }

  #endregion

  #region Task724

  [TestCase(new[] {1,7,3,6,5,6}, 3)]
  [TestCase(new[] {1,2,3}, -1)]
  [TestCase(new[] {2,1,-1}, 0)]
  public void Test724(int[] nums, int expected)
  {
    Assert.That(new Task724.Solution().PivotIndex(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task2215

  [TestCase(new[] {1,2,3}, new[] {2,4,6}, new[] {1,3}, new[] {4,6})]
  [TestCase(new[] {1,2,3,3}, new[] {1,1,2,2}, new[] {3}, new int[0])]
  public void Test2215(int[] nums1, int[] nums2, int[] expected1, int[] expected2)
  {
    Assert.That(
      new Task2215.Solution().FindDifference(nums1, nums2),
      Is.EqualTo(new List<IList<int>> {expected1, expected2}));
  }

  #endregion

  #region Task1207

  [TestCase(new[] {1,2,2,1,1,3}, true)]
  [TestCase(new[] {1,2}, false)]
  public void Test1207(int[] nums, bool expected)
  {
    Assert.That(new Task1207.Solution().UniqueOccurrences(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task933

  [TestCase(new[] { 1, 100, 3001, 3002 }, new[] { 1, 2, 3, 3 })]
  // [TestCase(new[] { 10, 3010, 6020 }, new[] { 1, 2, 2 })]
  public void Test933(int[] pings, int[] expectedResults)
    {
      var recentCounter = new RecentCounter();
      for (int i = 0; i < pings.Length; i++)
      {
        int result = recentCounter.Ping(pings[i]);
        Assert.That(result, Is.EqualTo(expectedResults[i]));
      }
    }

  #endregion

  #region Task206

  [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
  [TestCase(new[] { 1, 2}, new[] { 2, 1 })]
  [TestCase(new int[0], new int[0])]
  public void Test206(int[] nums, int[] expected)
  {
    var node = ListNodeBuilder.BuildListNodeFromArray(nums, 0);
    var actualNode = new Task206.Solution().ReverseList(node);

    var i = 0;
    while (actualNode.next != null)
    {
      Assert.That(actualNode.val, Is.EqualTo(expected[i]));
      i++;
      actualNode = actualNode.next;
    }
  }

  #endregion

  #region Task238

  [TestCase(new[] { 1,2,3,4 }, new[] { 24,12,8,6 })]
  [TestCase(new[] { -1,1,0,-3,3}, new[] { 0,0,9,0,0 })]
  public void Test238(int[] nums, int[] expected)
  {
    Assert.That(new Task238.Solution().ProductExceptSelf(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task374

  [TestCase(10, 6)]
  [TestCase(1, 1)]
  [TestCase(2, 1)]
  [TestCase(2126753390, 1702766719)]
  [TestCase(2147483647, 2147483647)]
  public void Test374(int num, int pick)
  {
    var guess = new Func<int, int>((n) =>
    {
      if (n > pick) return -1;
      if (n < pick) return 1;
      return 0;
    });

    Assert.That(new Task374.Solution().GuessNumber(num, guess), Is.EqualTo(pick));
  }

  #endregion

  #region Task388

  [TestCase(2, new[] {0,1,1})]
  [TestCase(5, new[] {0,1,1,2,1,2})]
  public void Test388(int n, int[] ans)
  {
    Assert.That(new Task388.Solution().CountBits(n), Is.EqualTo(ans));
  }

  #endregion

  #region Task334

  [TestCase(new[] {1,2,3,4,5}, true)]
  [TestCase(new[] {5,4,3,2,1}, false)]
  [TestCase(new[] {2,1,5,0,4,6}, true)]
  [TestCase(new[] {20,100,10,12,5,13}, true)]
  [TestCase(new[] {1,2,1,3}, true)]
  [TestCase(new[] {1,5,0,4,1,3}, true)]
  public void Test334(int[] nums, bool expected)
  {
    Assert.That(new Task334.Solution().IncreasingTriplet(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task1313

  [TestCase(new[] {1,2,3,4}, new[]{2,4,4,4})]
  [TestCase(new[] {1,1,2,3}, new[]{1,3,3})]
  public void Test334(int[] nums, int[] expected)
  {
    Assert.That(new Task1313.Solution().DecompressRLElist(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task104

  [TestCase(new[] {3,9,20,int.MinValue,int.MinValue,15,7}, 3)]
  public void Test104(int[] nums, int expected)
  {
    var node = TreeNodeBuilder.BuildTreeFromArray(nums);

    Assert.That(new Task104.Solution().MaxDepth(node), Is.EqualTo(expected));
  }

  #endregion

  #region Task136

  [TestCase(new[] {2,2,1}, 1)]
  [TestCase(new[] {4,1,2,1,2}, 4)]
  [TestCase(new[] {1}, 1)]
  public void Test136(int[] nums, int expected)
  {
    Assert.That(new Task136.Solution().SingleNumber(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task443

  [TestCase(new[] {'a','a','b','b','c','c','c'}, 6)]
  [TestCase(new[] {'a','b','c',}, 3)]
  [TestCase(new[] {'a'}, 1)]
  [TestCase(new[] {'a','a','a','a','a','b'}, 3)]
  [TestCase(new[] {'a','b','b','b','b','b','b','b','b','b','b','b','b'}, 4)]
  public void Test443(char[] chars, int expected)
  {
    Assert.That(new Task443.Solution().Compress(chars), Is.EqualTo(expected));
  }

  #endregion

  #region Task872

  [TestCase(new[] {3,5,1,6,2,9,8,int.MinValue,int.MinValue,7,4}, new[] {3,5,1,6,7,4,2,int.MinValue,int.MinValue,int.MinValue,int.MinValue,int.MinValue,int.MinValue,9,8}, true)]
  public void Test872(int[] root1Array, int[] root2Array, bool expected)
  {
    var root1 = TreeNodeBuilder.BuildTreeFromArray(root1Array);
    var root2 = TreeNodeBuilder.BuildTreeFromArray(root1Array);

    Assert.That(new Task872.Solution().LeafSimilar(root1, root2), Is.EqualTo(expected));
  }

  #endregion

  #region Task700

  [TestCase(new[] {4,2,7,1,3}, 2,new[] {2,1,3})]
  [TestCase(new[] {4,2,7,1,3}, 5,new int[0])]
  [TestCase(new[] {4}, 4,new[]{4})]
  [TestCase(new[] {4}, 5,new int[0])]
  public void Test700(int[] rootArray, int val, int[] expected)
  {
    var root = TreeNodeBuilder.BuildTreeFromArray(rootArray);

    Assert.That(
      TreeNodeBuilder.BuildArrayFromTreeNode(new Task700.Solution().SearchBST(root, val)),
      Is.EqualTo(expected));
  }

  #endregion

  #region Task1

  [TestCase(new[] {2,7,11,15}, 9, new[] {0,1})]
  [TestCase(new[] {3,2,4}, 6, new[] {1,2})]
  [TestCase(new[] {3,2,3}, 6, new[] {0,2})]
  [TestCase(new[] {3,3}, 6, new[] {0,1})]
  [TestCase(new[] {2,5,5,11}, 10, new[] {1,2})]
  public void Test1(int[] nums, int target, int[] expected)
  {
    var actual = new Task1.Solution().TwoSum(nums, target);
    Array.Sort(actual);
    Assert.That(actual, Is.EqualTo(expected));
  }

  #endregion

  #region Task11

  [TestCase(new[] {1,8,6,2,5,4,8,3,7}, 49)]
  [TestCase(new[] {1,1}, 1)]
  public void Test11(int[] height, int expected)
  {
    Assert.That(new Task11.Solution().MaxArea(height), Is.EqualTo(expected));
  }

  #endregion

  #region Task1679

  [TestCase(new[] {1,2,3,4}, 5, 2)]
  [TestCase(new[] {3,1,3,4,3}, 6, 1)]
  public void Test1679(int[] nums, int k, int expected)
  {
    Assert.That(new Task1679.Solution().MaxOperations(nums, k), Is.EqualTo(expected));
  }

  #endregion

  #region Task1456

  [TestCase("abciiidef", 3, 3)]
  [TestCase("aeiou", 2, 2)]
  [TestCase("leetcode", 3, 2)]
  [TestCase("leet", 3, 2)]
  [TestCase("eeet", 3, 3)]
  [TestCase("eee", 3, 3)]
  [TestCase("eek", 3, 2)]
  [TestCase("", 3, 0)]
  [TestCase("avcdce", 1, 1)]
  [TestCase("weallloveyou", 7, 4)]
  public void Test1456(string s, int k, int expected)
  {
    Assert.That(new Task1456.Solution().MaxVowels(s, k), Is.EqualTo(expected));
  }

  #endregion

  #region Task704

  [TestCase(new[] {-1,0,3,5,9,12}, 9, 4)]
  [TestCase(new[] {-1,0,3,5,9,12}, 2, -1)]
  public void Test704(int[] nums, int target, int expected)
  {
    Assert.That(new Task704.Solution().Search(nums, target), Is.EqualTo(expected));
  }

  #endregion

  #region Task13

  [TestCase("III", 3)]
  [TestCase("LVIII", 58)]
  [TestCase("MCMXCIV", 1994)]
  public void Test13(string s, int expected)
  {
    Assert.That(new Task13.Solution().RomanToInt(s), Is.EqualTo(expected));
  }

  #endregion

  #region Task1523

  [TestCase(3, 7, 3)]
  [TestCase(8, 10, 1)]
  public void Test1523(int l, int h, int expected)
  {
    Assert.That(new Task1523.Solution().CountOdds(l, h), Is.EqualTo(expected));
  }

  #endregion

  #region Task1491

  [TestCase(new [] {4000,3000,1000,2000}, 2500.0)]
  [TestCase(new [] {1000,2000,3000}, 2000.0)]
  public void Test1491(int[] salary, double expected)
  {
    var actual = new Task1491.Solution().Average(salary);
    Assert.That(actual - expected, Is.LessThanOrEqualTo(10e-5));
  }

  #endregion

  #region Task929

  [TestCase(new [] {"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"}, 2)]
  [TestCase(new [] {"a@leetcode.com","b@leetcode.com","c@leetcode.com"}, 3)]
  public void Test929(string[] emails, int expected)
  {
    Assert.That(new Task929.Solution().NumUniqueEmails(emails), Is.EqualTo(expected));
  }

  #endregion

  #region Task485

  [TestCase(new [] {1,1,0,1,1,1}, 3)]
  [TestCase(new [] {1,0,1,1,0,1}, 2)]
  public void Test485(int[] nums, int expected)
  {
    Assert.That(new Task485.Solution().FindMaxConsecutiveOnes(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task1137

  [TestCase(4, 4)]
  [TestCase(25, 1389537)]
  [TestCase(1, 1)]
  [TestCase(0, 0)]
  [TestCase(2, 1)]
  public void Test1137(int n, int expected)
  {
    Assert.That(new Task1137.Solution().Tribonacci(n), Is.EqualTo(expected));
  }

  #endregion

  #region Task17

  [TestCase("23", new [] {"ad","ae","af","bd","be","bf","cd","ce","cf"})]
  [TestCase("", new string[0])]
  [TestCase("2", new []{"a","b","c"})]
  public void Test17(string digits, string[] expected)
  {
    Assert.That(new Task17.Solution().LetterCombinations(digits), Is.EqualTo(expected));
  }

  #endregion

  #region Task2390

  [TestCase("leet**cod*e", "lecoe")]
  [TestCase("erase*****", "")]
  public void Test2390(string s, string expected)
  {
    Assert.That(new Task2390.Solution().RemoveStars(s), Is.EqualTo(expected));
  }

  #endregion

  #region Task2352

  [Test]
  public void Test2352_1()
  {
    int[][] grid = [[3,2,1],[1,7,6],[2,7,7]];
    var expected = 1;
    Assert.That(new Task2352.Solution().EqualPairs(grid), Is.EqualTo(expected));
  }

  [Test]
  public void Test2352_2()
  {
    int[][] grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]];
    var expected = 3;
    Assert.That(new Task2352.Solution().EqualPairs(grid), Is.EqualTo(expected));
  }

  [Test]
  public void Test2352_3()
  {
    int[][] grid = [[11,1],[1,11]];
    var expected = 2;
    Assert.That(new Task2352.Solution().EqualPairs(grid), Is.EqualTo(expected));
  }

  [Test]
  public void Test2352_4()
  {
    int[][] grid = [[13,13],[13,13]];
    var expected = 4;
    Assert.That(new Task2352.Solution().EqualPairs(grid), Is.EqualTo(expected));
  }

  #endregion

  #region Task9

  [TestCase(121, true)]
  [TestCase(-121, false)]
  [TestCase(10, false)]
  public void Test9(int x, bool expected)
  {
    Assert.That(new Task9.Solution().IsPalindrome(x), Is.EqualTo(expected));
  }

  #endregion

  #region Task394

  [TestCase("3[a]2[bc]", "aaabcbc")]
  [TestCase("3[a]", "aaa")]
  [TestCase("10[a]", "aaaaaaaaaa")]
  [TestCase("3[a]b", "aaab")]
  [TestCase("3[a]bc", "aaabc")]
  [TestCase("3[ab]", "ababab")]
  [TestCase("3[a]10[bc]", "aaabcbcbcbcbcbcbcbcbcbc")]
  [TestCase("3[a2[c]]", "accaccacc")]
  [TestCase("2[abc]3[cd]ef", "abcabccdcdcdef")]
  public void Test394(string s, string expected)
  {
    Assert.That(new Task394.Solution().DecodeString(s), Is.EqualTo(expected));
  }

  #endregion

  #region Task1004

  [TestCase(new [] {1,1,1,0,0,0,1,1,1,1,0}, 2, 6)]
  [TestCase(new [] {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1}, 3, 10)]
  public void Test1004(int[] nums, int k, int expected)
  {
    Assert.That(new Task1004.Solution().LongestOnes(nums, k), Is.EqualTo(expected));
  }

  #endregion

  #region Task1493

  [TestCase(new [] {1,1,0,1},  3)]
  [TestCase(new [] {0,1,1,1,0,1,1,0,1}, 5)]
  [TestCase(new [] {1,1,1}, 2)]
  public void Test1493(int[] nums, int expected)
  {
    Assert.That(new Task1493.Solution().LongestSubarray(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task1657

  [TestCase("abc",  "bca", true)]
  [TestCase("abc",  "def", false)]
  [TestCase("a",  "aa", false)]
  [TestCase("cabbba",  "abbccc", true)]
  [TestCase("abbzccca",  "babzzczc", true)]
  public void Test1657(string word1, string word2, bool expected)
  {
    Assert.That(new Task1657.Solution().CloseStrings(word1, word2), Is.EqualTo(expected));
  }

  #endregion
}