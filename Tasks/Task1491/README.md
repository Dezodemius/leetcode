# 1491. Average Salary Excluding the Minimum and Maximum Salary

## Problem Statement
Given an array of **unique** integers `salary` where `salary[i]` is the salary of the `i-th` employee, return the average salary of employees excluding the **minimum** and **maximum** salary.

**Note:** Answers within 10<sup>-5</sup> of the actual answer will be accepted.

---

## Examples

### Example 1
**Input:**  
`salary = [4000, 3000, 1000, 2000]`  
**Output:**  
`2500.00000`  
**Explanation:**
- Minimum salary = `1000`
- Maximum salary = `4000`
- Average of remaining salaries `(2000 + 3000) / 2 = 2500`

### Example 2
**Input:**  
`salary = [1000, 2000, 3000]`  
**Output:**  
`2000.00000`  
**Explanation:**
- Minimum salary = `1000`
- Maximum salary = `3000`
- Average of remaining salary `2000 / 1 = 2000`

---

## Constraints
- `3 <= salary.length <= 100`
- `1000 <= salary[i] <= 10^6`
- All integers in `salary` are **unique**.  