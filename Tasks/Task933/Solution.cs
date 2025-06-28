namespace Tasks.Task933;

public class RecentCounter
{
  private List<int> requests;
  public RecentCounter() {
    this.requests =  new List<int>();
  }

  public int Ping(int t) {
    this.requests.Add(t);
    var range1 = t - 3000;
    var range2 = t;
    var sum = 0;
    for (int i = 0; i < this.requests.Count; i++)
    {
      if (this.requests[i] >= range1 && this.requests[i] <= range2)
      {
        sum++;
      }
    }

    return sum;
  }
}