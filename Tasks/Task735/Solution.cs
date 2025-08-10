using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task735;

public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();
        var queue = new Queue<int>(asteroids.Length - 1);
        for (int i = 1; i < asteroids.Length; i++)
            queue.Enqueue(asteroids[i]);
    
        stack.Push(asteroids[0]);

        while (queue.TryDequeue(out var asteroid))
        {
            if (stack.Count == 0)
            {
                stack.Push(asteroid);
                continue;
            }
            while (stack.Count != 0)
            {
                var previous = stack.Peek();
                if (Math.Sign(asteroid) != Math.Sign(previous))
                {
                    if (Math.Sign(previous) < 0)
                    {
                        stack.Push(asteroid);
                        break;
                    }
                    if (Math.Abs(asteroid) > Math.Abs(previous))
                    {
                        stack.Pop();
                    }
                    else if (Math.Abs(asteroid) == Math.Abs(previous))
                    {
                        stack.Pop();
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    stack.Push(asteroid);
                    break;
                }

                if (stack.Count == 0)
                {
                    stack.Push(asteroid);
                    break;
                }
            }
        }

        return stack.Reverse().ToArray();
    }
}