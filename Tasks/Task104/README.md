# 104. Maximum Depth of Binary Tree

## Problem Statement
Given the root of a binary tree represented as an array (where `null` values indicate absence of nodes), return its maximum depth - the number of nodes along the longest path from the root to the farthest leaf node.

### Examples

#### Example 1
**Input:** `root = [3,9,20,null,null,15,7]`  
**Output:** `3`  
**Explanation:**
- Root (3) → Left (9) → Depth = 2
- Root (3) → Right (20) → Left (15) → Depth = 3
- Root (3) → Right (20) → Right (7) → Depth = 3  
  Longest path has 3 nodes.

#### Example 2
**Input:** `root = [1,null,2]`  
**Output:** `2`  
**Explanation:**
- Root (1) → Right (2) → Depth = 2

### Constraints
- Array length in range `[0, 10^4]`
- Node values between `-100` and `100`
- `null` represents missing nodes