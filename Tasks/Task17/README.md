# 17. Letter Combinations of a Phone Number

## Problem Statement
Given a string `digits` containing digits from `2` to `9` inclusive, return all possible letter combinations that the number could represent (following traditional phone keypad mapping). Return the answer in any order.

**Phone Keypad Mapping:**
2 → abc
3 → def
4 → ghi
5 → jkl
6 → mno
7 → pqrs
8 → tuv
9 → wxyz
---

## Examples

### Example 1
**Input:** `digits = "23"`  
**Output:** `["ad","ae","af","bd","be","bf","cd","ce","cf"]`  
**Explanation:**  
All possible combinations of letters from `2` (abc) and `3` (def).

### Example 2
**Input:** `digits = ""`  
**Output:** `[]`  
**Explanation:**  
Empty input yields empty output.

### Example 3
**Input:** `digits = "2"`  
**Output:** `["a","b","c"]`  
**Explanation:**  
Single digit returns its mapped letters.

---

## Constraints
- `0 <= digits.length <= 4`
- Each `digits[i]` is a digit in `['2','9']`