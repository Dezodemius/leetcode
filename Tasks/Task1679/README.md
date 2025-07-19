# 1679. Max Number of K-Sum Pairs

## Problem Statement
Given an integer array `nums` and an integer `k`, perform operations where each operation consists of:
1. Selecting two numbers from `nums` that sum to `k`
2. Removing these numbers from the array

Return the maximum number of such operations you can perform.

### Key Points:
- Each operation removes exactly two numbers
- Numbers can't be reused in multiple operations
- The goal is to maximize the number of valid operations

---

## Examples

### Example 1
**Input:**  
`nums = [1,2,3,4]`, `k = 5`  
**Output:**  
`2`  
**Explanation:**
1. Remove 1 and 4 → nums becomes [2,3]
2. Remove 2 and 3 → nums becomes []  
   No more pairs sum to 5.

### Example 2
**Input:**  
`nums = [3,1,3,4,3]`, `k = 6`  
**Output:**  
`1`  
**Explanation:**
1. Remove two 3's → nums becomes [1,4,3]  
   No remaining pairs sum to 6.

---

## Constraints
- `1 <= nums.length <= 10^5`
- `1 <= nums[i] <= 10^9`
- `1 <= k <= 10^9`