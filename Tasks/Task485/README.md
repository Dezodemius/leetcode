# 485. Max Consecutive Ones

## Problem Statement
Given a binary array `nums`, return the maximum number of consecutive `1`'s in the array.

---

## Examples

### Example 1
**Input:**  
`nums = [1,1,0,1,1,1]`  
**Output:** `3`  
**Explanation:**  
The longest sequence of consecutive `1`'s is `[1,1,1]` (last three digits).

### Example 2
**Input:**  
`nums = [1,0,1,1,0,1]`  
**Output:** `2`  
**Explanation:**  
The longest sequences of consecutive `1`'s are `[1,1]` (positions 2-3 and 5-6).

---

## Constraints
- `1 <= nums.length <= 10^5`
- `nums[i]` is either `0` or `1`