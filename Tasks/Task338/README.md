# 338. Counting Bits

**Problem Statement:**  
Given an integer `n`, return an array `ans` of length `n + 1` such that for each `i` (`0 <= i <= n`), `ans[i]` is the number of `1`'s in the binary representation of `i`.

---

### **Examples**

**Example 1:**  
**Input:** `n = 2`  
**Output:** `[0, 1, 1]`  
**Explanation:**
- `0` → `0` (0 ones)
- `1` → `1` (1 one)
- `2` → `10` (1 one)

**Example 2:**  
**Input:** `n = 5`  
**Output:** `[0, 1, 1, 2, 1, 2]`  
**Explanation:**
- `0` → `0` (0 ones)
- `1` → `1` (1 one)
- `2` → `10` (1 one)
- `3` → `11` (2 ones)
- `4` → `100` (1 one)
- `5` → `101` (2 ones)

---

### **Constraints**
- `0 <= n <= 10^5`

---

### **Follow-up Questions**
1. Can you solve it in **linear time O(n)** and possibly in a **single pass**?
2. Can you do it **without using any built-in function** (e.g., `__builtin_popcount` in C++)?

---