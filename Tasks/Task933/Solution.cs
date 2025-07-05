using System.Collections.Generic;

namespace Tasks.Task933;

public class RecentCounter
{
  private Queue<int> requests;
  public RecentCounter() {
    this.requests =  new Queue<int>();
  }

  public int Ping(int t) {
    this.requests.Enqueue(t);

    while(requests.Peek() < t - 3000)
    {
      this.requests.Dequeue();
    }

    return this.requests.Count;
  }
}