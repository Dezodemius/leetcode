# 649. Dota2 Senate

## Problem Statement
In the Dota2 Senate, two parties (Radiant `'R'` and Dire `'D'`) compete in a round-based voting process. Each senator can:
1. **Ban** an opposing senator's voting rights (current and future rounds)
2. **Declare victory** if all remaining voters are from their party

Senators vote in order, skipping banned members. Determine the winning party assuming optimal strategies.

---

## Examples

### Example 1
**Input:** `senate = "RD"`  
**Output:** `"Radiant"`  
**Round 1:**
- R bans next D → Remaining: R  
  **Round 2:**
- R declares victory (no opponents left)

### Example 2
**Input:** `senate = "RDD"`  
**Output:** `"Dire"`  
**Round 1:**
- R bans first D → Remaining: R, D
- Next D bans R → Remaining: D  
  **Round 2:**
- D declares victory

---

## Constraints
- `n == senate.length`
- `1 ≤ n ≤ 10^4`
- `senate[i] ∈ {'R', 'D'}` 