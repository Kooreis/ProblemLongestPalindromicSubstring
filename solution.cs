```C#
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Longest Palindromic Substring: " + LongestPalindromicSubstring(input));
    }

    static string LongestPalindromicSubstring(string s)
    {
        int n = s.Length;
        bool[,] dp = new bool[n, n];
        string longestPalindromicSubstring = "";
        int maxLength = 0;

        for (int length = 1; length <= n; length++)
        {
            for (int start = 0; start < n; start++)
            {
                int end = start + length - 1;
                if (end >= n)
                {
                    break;
                }

                dp[start, end] = (length == 1 || length == 2 || dp[start + 1, end - 1]) && s[start] == s[end];

                if (dp[start, end] && length > maxLength)
                {
                    maxLength = length;
                    longestPalindromicSubstring = s.Substring(start, length);
                }
            }
        }

        return longestPalindromicSubstring;
    }
}
```