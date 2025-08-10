using System.Collections.Generic;

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
        while (queue.TryDequeue(out char senator))
        {
            if (queue.TryPeek(out var nextSenator))
            {
                if (nextSenator != senator)
                {
                    queue.Dequeue();
                    res = senator;
                }
                else
                {
                    res = senator;
                }
            }
            else
            {
                res = senator;
            }
        }

        return res == R ? Radiant : Dire;
    }
}