namespace Tasks.Task933;

public class RecentCounter
{
  private HashSet<int> requests;
  public RecentCounter() {
    this.requests =  new HashSet<int>();
  }

  public int Ping(int t) {
    this.requests.Add(t);
    var range1 = t - 3000;
    var range2 = t;
    var sum = 0;
    foreach (var request in this.requests)
    {
      if (request >= range1 && request <= range2)
      {
        sum++;
      }
    }

    return sum;
  }
}