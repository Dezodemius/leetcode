# 1657. Determine if Two Strings Are Close

## Problem Statement
Two strings `word1` and `word2` are considered **close** if you can transform one into the other using these operations any number of times:
1. **Swap any two existing characters**  
   Example: `"abc"` → `"acb"` (swap 'b' and 'c')
2. **Transform all occurrences of one character to another, and vice versa**  
   Example: `"aacabb"` → `"bbcbaa"` (swap 'a' and 'b' mappings)

Return `true` if the strings are close, otherwise `false`.

---

## Examples

### Example 1
**Input:**  
`word1 = "abc"`, `word2 = "bca"`  
**Output:** `true`  
**Explanation:**  
Swap 'b' and 'a' → `"bac"`, then swap 'a' and 'c' → `"bca"`

### Example 2
**Input:**  
`word1 = "a"`, `word2 = "aa"`  
**Output:** `false`  
**Explanation:**  
Cannot create additional characters or change frequency

### Example 3
**Input:**  
`word1 = "cabbba"`, `word2 = "abbccc"`  
**Output:** `true`  
**Explanation:**
1. Swap 'a' and 'c' → `"c"` becomes `"a"`, `"a"` becomes `"c"`  
   Result: `"aacccb"`
2. Sort frequencies → Both strings have counts [3,2,1]

---

## Constraints
- `1 ≤ word1.length, word2.length ≤ 10^5`
- Both strings contain only lowercase English letters (`a-z`)