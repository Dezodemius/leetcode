# 1732. Find the Highest Altitude

There is a biker going on a road trip. The road trip consists of `n + 1` points at different altitudes. The biker starts his trip on point 0 with altitude equal to 0.

You are given an integer array `gain` of length `n` where `gain[i]` is the net gain in altitude between points `i` and `i + 1` for all `0 <= i < n`.  
Return the highest altitude of a point.

---

## Example 1

**Input:**
```
gain = [-5, 1, 5, 0, -7]
```

**Output:**
```
1
```

**Explanation:**  
The altitudes are calculated as follows:
- Start at 0
- 0 + (-5) = -5
- -5 + 1 = -4
- -4 + 5 = 1
- 1 + 0 = 1
- 1 + (-7) = -6

So, the altitudes at each point are:  
`[0, -5, -4, 1, 1, -6]`  
The highest altitude is **1**.

---

## Example 2

**Input:**
```
gain = [-4, -3, -2, -1, 4, 3, 2]
```

**Output:**
```
0
```

**Explanation:**  
The altitudes are:
- Start at 0
- 0 + (-4) = -4
- -4 + (-3) = -7
- -7 + (-2) = -9
- -9 + (-1) = -10
- -10 + 4 = -6
- -6 + 3 = -3
- -3 + 2 = -1

So, the altitudes at each point are:  
`[0, -4, -7, -9, -10, -6, -3, -1]`  
The highest altitude is **0**.

---

## Constraints

- `n == gain.length`
- `1 <= n <= 100`
- `-100 <= gain[i] <= 100`

---