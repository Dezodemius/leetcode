using System.Text;

namespace Tasks.Task1768;

public class Solution {
  public string MergeAlternately(string word1, string word2) {
    var word1Length = word1.Length;
    var word2Length = word2.Length;
    var max = word1Length > word2Length ? word1Length : word2Length;

    StringBuilder result =new StringBuilder();
    int i = 0;
    int j = 0;
    while (max != 0){
      if (i <= word1Length - 1) {
        result.Append(word1[i]);
        i++;
      }
      if (j <= word2Length - 1) {
        result.Append(word2[j]);
        j++;
      }

      max--;
    }

    return result.ToString();
  }
}