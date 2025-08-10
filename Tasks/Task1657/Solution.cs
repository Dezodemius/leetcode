using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task1657;

public class Solution
{
    /// <summary>
    /// <see cref="Task1004.Solution"/>
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns></returns>
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;

        var sortedWord1 = word1.OrderBy(c => c);
        var sortedWord2 = word2.OrderBy(c => c);
        if (sortedWord1.SequenceEqual(sortedWord2))
            return true;

        var word1Freq = new Dictionary<char, int>();
        var word2Freq = new Dictionary<char, int>();

        for (int i = 0; i < word1.Length; i++)
        {
            if (word1Freq.TryGetValue(word1[i], out int value1))
                word1Freq[word1[i]] = ++value1;
            else
                word1Freq.TryAdd(word1[i], 1);   
            if (word2Freq.TryGetValue(word2[i], out int value2))
                word2Freq[word2[i]] = ++value2;
            else
                word2Freq.TryAdd(word2[i], 1);
        }
        
        var keys1 = word1Freq.Keys.ToArray();
        var keys2 = word2Freq.Keys.ToArray();
        if (keys1.Except(keys2).Any())
            return false;

        var freq1Values = word1Freq.Values.ToArray();
        var freq2Values = word2Freq.Values.ToArray();
        Array.Sort(freq1Values);
        Array.Sort(freq2Values);
        return freq1Values.SequenceEqual(freq2Values);
    }
}