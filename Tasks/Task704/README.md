# 704. Binary Search

## Problem Statement
Given a **sorted** (in ascending order) array of integers `nums` and an integer `target`, write a function to search for `target` in `nums`. If the target exists, return its index. Otherwise, return `-1`.

**Note:**  
The algorithm must run in **O(log n)** runtime complexity.

---

## Examples

### Example 1
**Input:**  
`nums = [-1, 0, 3, 5, 9, 12]`, `target = 9`  
**Output:** `4`  
**Explanation:**  
The number `9` exists in `nums` at index `4`.

### Example 2
**Input:**  
`nums = [-1, 0, 3, 5, 9, 12]`, `target = 2`  
**Output:** `-1`  
**Explanation:**  
The number `2` does not exist in `nums`, so the function returns `-1`.

---

## Constraints
- `1 <= nums.length <= 10^4`
- `-10^4 < nums[i], target < 10^4`
- All integers in `nums` are **unique**.
- `nums` is **sorted** in ascending order.  