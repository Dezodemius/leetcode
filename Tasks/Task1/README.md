# 1. Two Sum

## Problem Statement
Given an array of integers `nums` and an integer `target`, return the indices of the two numbers that add up to the target value.

### Key Requirements:
- Each input has exactly **one valid solution**
- Cannot use the same element twice
- Return indices in any order

---

## Examples

### Example 1
**Input:**  
`nums = [2, 7, 11, 15]`, `target = 9`  
**Output:**  
`[0, 1]`  
**Explanation:**  
`nums[0] + nums[1] = 2 + 7 = 9`

### Example 2
**Input:**  
`nums = [3, 2, 4]`, `target = 6`  
**Output:**  
`[1, 2]`  
**Explanation:**  
`nums[1] + nums[2] = 2 + 4 = 6`

### Example 3
**Input:**  
`nums = [3, 3]`, `target = 6`  
**Output:**  
`[0, 1]`

---

## Constraints
- Array length: `2 <= nums.length <= 10^4`
- Element values: `-10^9 <= nums[i] <= 10^9`
- Target range: `-10^9 <= target <= 10^9`
- Exactly **one valid solution** exists

---