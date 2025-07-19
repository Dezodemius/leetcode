# 700. Search in a Binary Search Tree

## Problem Statement
Given the root of a binary search tree (BST) and an integer `val`, find the node in the BST where the node's value equals `val` and return the subtree rooted at that node. If such a node does not exist, return `null`.

### Key Properties:
- **BST Structure**: For any given node:
    - All values in the left subtree are less than the node's value
    - All values in the right subtree are greater than the node's value
- The solution must maintain the BST properties during search

---

## Examples

### Example 1
**Input:**  
`root = [4,2,7,1,3]`, `val = 2`  
**Output:** `[2,1,3]`  
**Explanation:**  
The node with value 2 exists in the BST, so we return its subtree.

### Example 2
**Input:**  
`root = [4,2,7,1,3]`, `val = 5`  
**Output:** `[]`  
**Explanation:**  
No node with value 5 exists in the BST, so we return `null` (represented as empty list).

---

## Constraints
- The number of nodes in the tree ranges from `1` to `5000`
- Node values are between `1` and `10^7`
- It is guaranteed that `root` is a valid BST
- The search value `val` is between `1` and `10^7`

---