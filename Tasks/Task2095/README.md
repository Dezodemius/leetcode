# 2095. Delete the Middle Node of a Linked List

## Problem Statement
Given the head of a linked list, delete the middle node and return the modified list's head. The middle node is defined as the ⌊n/2⌋th node (0-based index) where n is the list size.

---

## Examples

### Example 1
**Input:** `head = [1,3,4,7,1,2,6]`  
**Output:** `[1,3,4,1,2,6]`  
**Explanation:**  
For n=7, middle node is index 3 (value 7). After deletion: [1,3,4,1,2,6]

### Example 2
**Input:** `head = [1,2,3,4]`  
**Output:** `[1,2,4]`  
**Explanation:**  
For n=4, middle node is index 2 (value 3). After deletion: [1,2,4]

### Example 3
**Input:** `head = [2,1]`  
**Output:** `[2]`  
**Explanation:**  
For n=2, middle node is index 1 (value 1). After deletion: [2]

---

## Constraints
- List size: `[1, 10^5]`
- Node values: `[1, 10^5]`