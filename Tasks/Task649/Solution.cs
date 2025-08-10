using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task649;

public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        char res = '\0';
        const string Radiant = "Radiant";
        const char R = 'R';
        const string Dire = "Dire";
        const char D = 'D';

        var queue = new Queue<char>(senate);
        
        var countR = senate.Count(x => x == R);
        var countD = senate.Length - countR;
        var direction = 0;

        while (countD > 0 && countR > 0)
        {
            char senator = queue.Dequeue();
            if (senator == R)
            {
                if (direction >= 0)
                {
                    countD--;
                    queue.Enqueue(senator);
                }
                direction++;
            }
            if (senator == D)
            {
                if (direction <= 0)
                {
                    countR--;
                    queue.Enqueue(senator);
                }
                direction--;
            }
        }
        
        return countR != 0 ? Radiant : Dire;
    }
}