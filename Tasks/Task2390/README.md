# 2390. Removing Stars From a String

## Problem Statement
Given a string `s` containing lowercase English letters and stars (`*`), process the string by repeatedly performing the following operation:
- For each star (`*`), remove:
    - The closest non-star character to its left
    - The star itself

Return the final string after all stars have been processed.

**Note:**
- The input guarantees all operations are possible
- The result is always unique

---

## Examples

### Example 1
**Input:** `s = "leet**cod*e"`  
**Output:** `"lecoe"`  
**Step-by-step:**
1. Remove `'t'` and first `*` → `"lee*cod*e"`
2. Remove `'e'` and second `*` → `"lecod*e"`
3. Remove `'d'` and third `*` → `"lecoe"`

### Example 2
**Input:** `s = "erase*****"`  
**Output:** `""`  
**Explanation:**  
All characters get removed sequentially by 5 stars.

---

## Constraints
- `1 ≤ s.length ≤ 10^5`
- `s` consists of lowercase letters (`a-z`) and `*`
- Operations will always be valid