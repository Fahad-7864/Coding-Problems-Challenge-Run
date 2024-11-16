using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */
    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> sockCounts = new Dictionary<int, int>();
        int pairs = 0;

        foreach (int sock in ar)
        {
            if (sockCounts.ContainsKey(sock))
            {
                sockCounts[sock]++;
            }
            else
            {
                sockCounts[sock] = 1;
            }
        }

        foreach (var count in sockCounts.Values)
        {
            pairs += count / 2;
        }

        return pairs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Custom Test Cases
        RunTest(9, new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3); // Expected output: 3
        RunTest(5, new List<int> { 1, 2, 1, 2, 1 }, 2);                     // Expected output: 2
        RunTest(7, new List<int> { 10, 10, 10, 10, 10, 10, 10 }, 3);        // Expected output: 3
        RunTest(4, new List<int> { 1, 2, 3, 4 }, 0);                       // Expected output: 0
    }

    private static void RunTest(int n, List<int> ar, int expected)
    {
        int result = Result.sockMerchant(n, ar);
        Console.WriteLine($"Input Array: {string.Join(" ", ar)}");
        Console.WriteLine($"Expected Output: {expected}");
        Console.WriteLine($"Actual Output: {result}");
        Console.WriteLine(result == expected ? "Test Passed\n" : "Test Failed\n");
    }
}
