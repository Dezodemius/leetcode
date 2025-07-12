using Tasks.Task206;
using Tasks.Task933;

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
  [TestCase(new[] { 10, 3010, 6020 }, new[] { 1, 2, 2 })]
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

  public static ListNode CreateListNode(int[] nums, int index)
  {
    if (!nums.Any())
      return new ListNode();
    if (index >= nums.Length - 1)
      return new ListNode(nums[index]);

    return new ListNode(nums[index], CreateListNode(nums, ++index));
  }

  [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
  [TestCase(new[] { 1, 2}, new[] { 2, 1 })]
  [TestCase(new int[0], new int[0])]
  public void Test206(int[] nums, int[] expected)
  {
    var node = CreateListNode(nums, 0);
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

  [TestCase(2, new int[] {0,1,1})]
  [TestCase(5, new int[] {0,1,1,2,1,2})]
  public void Test388(int n, int[] ans)
  {
    Assert.That(new Task388.Solution().CountBits(n), Is.EqualTo(ans));
  }

  #endregion

  #region Task334

  [TestCase(new int[] {1,2,3,4,5}, true)]
  [TestCase(new int[] {5,4,3,2,1}, false)]
  [TestCase(new int[] {2,1,5,0,4,6}, true)]
  [TestCase(new int[] {20,100,10,12,5,13}, true)]
  [TestCase(new int[] {1,2,1,3}, true)]
  [TestCase(new int[] {1,5,0,4,1,3}, true)]
  public void Test334(int[] nums, bool expected)
  {
    Assert.That(new Task334.Solution().IncreasingTriplet(nums), Is.EqualTo(expected));
  }

  #endregion

  #region Task443

  [TestCase(new Char[] {'a','a','b','b','c','c','c'}, 6)]
  [TestCase(new Char[] {'a','b','c',}, 3)]
  [TestCase(new Char[] {'a'}, 1)]
  [TestCase(new Char[] {'a','a','a','a','a','b'}, 3)]
  [TestCase(new Char[] {'a','b','b','b','b','b','b','b','b','b','b','b','b'}, 4)]
  public void Test443(char[] chars, int expected)
  {
    Assert.That(new Task443.Solution().Compress(chars), Is.EqualTo(expected));
  }

  #endregion
}