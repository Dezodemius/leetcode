# 2352. Equal Row and Column Pairs

## Problem Statement
Given an n×n integer matrix `grid`, return the number of index pairs `(rᵢ, cⱼ)` where row `rᵢ` and column `cⱼ` contain identical elements in the same order.

---

## Examples

### Example 1
**Input:**  
`grid = [[3,2,1],  
         [1,7,6],  
         [2,7,7]]`  
**Output:** `1`  
**Valid Pair:**
- (Row 2, Column 1): `[2,7,7]`

### Example 2
**Input:**  
`grid = [[3,1,2,2],  
         [1,4,4,5],  
         [2,4,2,2],  
         [2,4,2,2]]`  
**Output:** `3`  
**Valid Pairs:**
1. (Row 0, Column 0): `[3,1,2,2]`
2. (Row 2, Column 2): `[2,4,2,2]`
3. (Row 3, Column 2): `[2,4,2,2]`

---

## Constraints
- `n == grid.length == grid[i].length`
- `1 ≤ n ≤ 200`
- `1 ≤ grid[i][j] ≤ 10⁵`  