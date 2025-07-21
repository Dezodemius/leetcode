using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task929;

public class Solution {
  public int NumUniqueEmails(string[] emails) {
    var parsedEmails = new HashSet<string>();
    foreach (var email in emails) {
      var parts = email.Split('@');
      var domain = parts.Last();
      var local = parts[0].Split('+')[0];
      int index = local.IndexOf('.');
      while (index != -1)
      {
        local = local.Remove(index, 1);
        index = local.IndexOf('.');
      }

      var parsedEmail = $"{local}@{domain}";
      parsedEmails.Add(parsedEmail);
    }
    return parsedEmails.Count;
  }
}