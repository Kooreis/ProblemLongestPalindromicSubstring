Here is a Python console application that finds the longest palindromic substring in a given string:

```python
def longest_palindrome(s):
    def expand_around_center(s, left, right):
        while left >= 0 and right < len(s) and s[left] == s[right]:
            left -= 1
            right += 1
        return s[left + 1:right]

    longest = ""
    for i in range(len(s)):
        palindrome_odd = expand_around_center(s, i, i)
        palindrome_even = expand_around_center(s, i, i + 1)
        longest = max(longest, palindrome_odd, palindrome_even, key=len)
    return longest

def main():
    s = input("Enter a string: ")
    print("Longest palindromic substring: ", longest_palindrome(s))

if __name__ == "__main__":
    main()
```

You can run this console application, it will ask you to enter a string and then it will print the longest palindromic substring in the given string.