# 443. String Compression

## Problem Statement
Given an array of characters `chars`, compress it using the following algorithm:

1. Begin with an empty string `s`. For each group of consecutive repeating characters in `chars`:
    - If the group's length is 1, append the character to `s`.
    - Otherwise, append the character followed by the group's length.
2. The compressed string `s` should **not** be returned separately but instead be stored **in the input array** `chars`.
3. Group lengths ≥10 must be split into multiple characters (e.g., `12` becomes `'1','2'`).
4. Return the new length of the array after compression.

**Constraints:**
- `1 <= chars.length <= 2000`
- `chars[i]` can be a lowercase/uppercase English letter, digit, or symbol.
- You must use **only constant extra space** (O(1)).

---

## Examples

### Example 1
**Input:**  
`chars = ["a","a","b","b","c","c","c"]`  
**Output:**  
Return `6`, and the first 6 characters become `["a","2","b","2","c","3"]`  
**Explanation:**  
Groups are `"aa"`, `"bb"`, and `"ccc"` → compressed to `"a2b2c3"`.

### Example 2
**Input:**  
`chars = ["a"]`  
**Output:**  
Return `1`, array remains `["a"]`  
**Explanation:**  
Single character stays uncompressed.

### Example 3
**Input:**  
`chars = ["a","b","b","b",...,"b"]` (12 `'b'`s)  
**Output:**  
Return `4`, first 4 characters become `["a","b","1","2"]`  
**Explanation:**  
Groups are `"a"` and `"bbbbbbbbbbbb"` → compressed to `"ab12"`.