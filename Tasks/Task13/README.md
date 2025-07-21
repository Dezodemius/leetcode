# 13. Roman to Integer

## Problem Statement
Roman numerals are represented by seven different symbols:

| Symbol | Value |
|--------|-------|
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

Roman numerals are typically written from largest to smallest from left to right. However, there are six special cases where subtraction is used:
- I before V (4) or X (9)
- X before L (40) or C (90)
- C before D (400) or M (900)

Given a Roman numeral string `s`, convert it to an integer.

---

## Examples

### Example 1
**Input:** `s = "III"`  
**Output:** `3`  
**Explanation:**  
I + I + I = 1 + 1 + 1 = 3

### Example 2
**Input:** `s = "LVIII"`  
**Output:** `58`  
**Explanation:**  
L + V + I + I + I = 50 + 5 + 1 + 1 + 1 = 58

### Example 3
**Input:** `s = "MCMXCIV"`  
**Output:** `1994`  
**Explanation:**  
M + CM + XC + IV = 1000 + 900 + 90 + 4 = 1994

---

## Constraints
- `1 <= s.length <= 15`
- `s` contains only the characters `('I', 'V', 'X', 'L', 'C', 'D', 'M')`
- `s` is a valid Roman numeral in the range `[1, 3999]`