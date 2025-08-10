# 735. Asteroid Collision

## Problem Statement
Given an array `asteroids` where each element represents an asteroid (absolute value = size, sign = direction), determine the state of asteroids after all collisions:
- **Right-moving**: Positive numbers (→)
- **Left-moving**: Negative numbers (←)
- **Collision Rules**:
    - Smaller asteroid explodes
    - Equal size: Both explode
    - Same direction: No collision

Return the surviving asteroids in their original order.

---

## Examples

### Example 1
**Input:** `asteroids = [5,10,-5]`  
**Output:** `[5,10]`  
**Explanation:**
- 10 (→) collides with -5 (←) → -5 explodes
- 5 (→) and 10 (→) never collide

### Example 2
**Input:** `asteroids = [8,-8]`  
**Output:** `[]`  
**Explanation:**  
8 (→) and -8 (←) annihilate each other

### Example 3
**Input:** `asteroids = [10,2,-5]`  
**Output:** `[10]`  
**Explanation:**
1. 2 (→) collides with -5 (←) → 2 explodes
2. 10 (→) collides with -5 (←) → -5 explodes

---

## Constraints
- `2 ≤ asteroids.length ≤ 10^4`
- `-1000 ≤ asteroids[i] ≤ 1000`
- No zero values