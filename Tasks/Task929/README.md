# 929. Unique Email Addresses

## Problem Statement
Every valid email consists of:
- A **local name** (before '@')
- A **domain name** (after '@')

Special rules for email processing:
1. **Dot (.) in local name**: Ignored (e.g., `a.lice@com` → `alice@com`)
2. **Plus (+) in local name**: Ignores all subsequent characters until '@' (e.g., `a+lice@com` → `a@com`)
3. **Domain name**: No modifications applied

Given an array of email strings, return the count of **unique addresses** that actually receive emails after applying these rules.

---

## Examples

### Example 1
**Input:**  
`emails = ["test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"]`  
**Output:** `2`  
**Explanation:**
- `test.email+alex@leetcode.com` → `testemail@leetcode.com`
- `test.e.mail+bob.cathy@leetcode.com` → `testemail@leetcode.com`
- `testemail+david@lee.tcode.com` → `testemail@lee.tcode.com`  
  Unique addresses: `testemail@leetcode.com` and `testemail@lee.tcode.com`

### Example 2
**Input:**  
`emails = ["a@leetcode.com", "b@leetcode.com", "c@leetcode.com"]`  
**Output:** `3`  
**Explanation:**  
All emails remain distinct after processing.

---

## Constraints
- `1 ≤ emails.length ≤ 100`
- `1 ≤ emails[i].length ≤ 100`
- **Character set**: Lowercase letters (`a-z`), `+`, `.`, `@`
- Exactly one `@` per email
- Non-empty local/domain names
- Local names don't start with `+`
- Domain names end with `.com` and have at least one preceding character