using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

  public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> arr = new List<int>();

        for (int j = 0; j < queries.Count; j++)
        {
            int numofapp = 0;
            for (int i = 0; i < strings.Count; i++)
            {
                if (queries[j].Equals(strings[i]))
                {
                    numofapp++;
                }
            }
            arr.Add(numofapp);
        }

        return arr;
    }


    public static void RunTests()
    {
        List<(List<string> strings, List<string> queries, List<int> expectedOutput)> testCases = new List<(List<string>, List<string>, List<int>)>
        {
            (new List<string> { "aba", "baba", "aba", "xzxb" }, new List<string> { "aba", "xzxb", "ab" }, new List<int> { 2, 1, 0 }),
            (new List<string> { "def", "de", "fgh" }, new List<string> { "de", "lmn", "fgh" }, new List<int> { 1, 0, 1 }),
            (new List<string> { "abc", "abc", "abc", "def", "def", "xyz" }, new List<string> { "abc", "def" }, new List<int> { 3, 2 }),
            (new List<string> { "alpha", "beta", "gamma", "alpha", "delta", "epsilon", "gamma", "beta", "beta", "alpha" },
             new List<string> { "alpha", "beta", "gamma", "theta" }, new List<int> { 3, 3, 2, 0 }),
            (new List<string> { "Hello", "hello", "HELLO", "World", "world" }, new List<string> { "hello", "Hello", "WORLD" }, new List<int> { 1, 1, 0 })
        };

        foreach (var (strings, queries, expectedOutput) in testCases)
        {
            List<int> result = matchingStrings(strings, queries);
            Console.WriteLine(result.SequenceEqual(expectedOutput) ? "Pass" : $"Fail - Expected: {string.Join(", ", expectedOutput)} | Got: {string.Join(", ", result)}");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.RunTests();
    }
}
