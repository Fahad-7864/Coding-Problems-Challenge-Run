// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using System;
using System.Collections.Generic;

class Result
{
    public static string pangrams(string s)
    {
        s = s.ToLower();
        HashSet<char> uniqueLetters = new HashSet<char>();

        // Loop through
        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
            {
                uniqueLetters.Add(c);
            }
        }

        // Check to see all 26 letters
        return uniqueLetters.Count == 26 ? "pangram" : "not pangram";
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        // Custom Test Cases
        RunTest("The quick brown fox jumps over the lazy dog", "pangram"); // All letters are present
        RunTest("Hello World", "not pangram"); // Missing many letters
        RunTest("Pack my box with five dozen liquor jugs", "pangram"); // All letters are present
        RunTest("Sphinx of black quartz judge my vow", "pangram"); // All letters are present in a different sentence structure
        RunTest("Just a simple sentence", "not pangram"); 
    }

    public static void RunTest(string input, string expected)
    {
        string result = Result.pangrams(input);
        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Expected: {expected}");
        Console.WriteLine($"Actual: {result}");
        Console.WriteLine(result == expected ? "PASS" : "FAIL");
        Console.WriteLine();
    }
}
