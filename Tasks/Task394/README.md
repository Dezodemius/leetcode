# 394. Decode String

## Problem Statement
Given an encoded string following the pattern `k[encoded_string]`, where `k` is a positive integer, return the decoded string by repeating the `encoded_string` exactly `k` times.

**Encoding Rules:**
- Nested encodings are allowed (e.g., `3[a2[c]]` → `accaccacc`)
- Input is always valid with properly matched brackets
- Digits are only used for repetition counts (no numbers in original strings)

---

## Examples

### Example 1
**Input:** `s = "3[a]2[bc]"`  
**Output:** `"aaabcbc"`  
**Explanation:**
- `3[a]` → `aaa`
- `2[bc]` → `bcbc`  
  Combined: `aaa + bcbc = aaabcbc`

### Example 2
**Input:** `s = "3[a2[c]]"`  
**Output:** `"accaccacc"`  
**Explanation:**
- Innermost `2[c]` → `cc`
- Outer `3[acc]` → `accaccacc`

### Example 3
**Input:** `s = "2[abc]3[cd]ef"`  
**Output:** `"abcabccdcdcdef"`  
**Explanation:**
- `2[abc]` → `abcabc`
- `3[cd]` → `cdcdcd`
- `ef` remains as is  
  Combined: `abcabc + cdcdcd + ef = abcabccdcdcdef`

---

## Constraints
- `1 ≤ s.length ≤ 30`
- Contains: lowercase letters (`a-z`), digits (`0-9`), and brackets (`[]`)
- Integers range: `[1, 300]`
- Output length ≤ 10⁵