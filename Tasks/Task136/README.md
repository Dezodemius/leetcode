# 136. Single Number

## Problem Statement
Given a **non-empty** array of integers `nums`, where every element appears **exactly twice** except for one element which appears **only once**, find that single element.

### Requirements:
- Implement a solution with **O(n)** runtime complexity.
- Use only **O(1)** extra space (constant memory).

---

## Examples

### Example 1
**Input:** `nums = [2, 2, 1]`  
**Output:** `1`  
**Explanation:**  
The numbers `2` appear twice, and `1` appears once.

### Example 2
**Input:** `nums = [4, 1, 2, 1, 2]`  
**Output:** `4`  
**Explanation:**  
The numbers `1` and `2` appear twice, and `4` appears once.

### Example 3
**Input:** `nums = [1]`  
**Output:** `1`  
**Explanation:**  
There's only one element in the array, so it's the single one by default.

---

## Constraints
- `1 <= nums.length <= 3 * 10^4`
- `-3 * 10^4 <= nums[i] <= 3 * 10^4`
- **Guaranteed:** All elements appear exactly twice except for one unique element.