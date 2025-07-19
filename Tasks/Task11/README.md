# 11. Container With Most Water

## Problem Statement
Given an array `height` where each element represents the height of a vertical line at that index, find two lines that form a container with the x-axis that can hold the most water.

### Key Points:
- The container's walls are two vertical lines
- The area is calculated as: `width * min(height[left], height[right])`
- You cannot slant the container

---

## Examples

### Example 1
**Input:**  
`height = [1,8,6,2,5,4,8,3,7]`  
**Output:**  
`49`  
**Explanation:**  
The maximum area is formed between lines at indices 1 (height=8) and 8 (height=7).  
Area = width * min(8,7) = (8-1)*7 = 49

### Example 2
**Input:**  
`height = [1,1]`  
**Output:**  
`1`  
**Explanation:**  
The only possible container has area = (1-0)*1 = 1

---

## Constraints
- `2 <= height.length <= 10^5`
- `0 <= height[i] <= 10^4`