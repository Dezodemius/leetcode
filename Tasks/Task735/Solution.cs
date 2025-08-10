using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Task735;

public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();
        stack.Push(asteroids[0]);

        for (var i = 1; i < asteroids.Length; i++)
        {
            var current = asteroids[i];
            if (stack.Count == 0)
                stack.Push(current);
            while (stack.Count != 0)
            {
                var previous = stack.Peek();
                if (Math.Sign(current) != Math.Sign(previous))
                {
                    if (Math.Sign(previous) < 0)
                    {
                        stack.Push(current);
                        break;
                    }
                    if (Math.Abs(current) > Math.Abs(previous))
                    {
                        stack.Pop();
                    }
                    else if (Math.Abs(current) == Math.Abs(previous))
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
                    stack.Push(current);
                    break;
                }

                if (stack.Count == 0 && i == asteroids.Length - 1)
                {
                    stack.Push(current);
                }
            }
        }

        return stack.Reverse().ToArray();
    }
}