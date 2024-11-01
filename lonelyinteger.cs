using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

 public static int lonelyinteger(List<int> a)
{
    a.Sort();

    // Check in pairs; the unique one will not have a pair
    for (int i = 0; i < a.Count - 1; i += 2)
    {
        if (a[i] != a[i + 1])
            return a[i];
    }

    // If the unique element is the last one
    return a[a.Count - 1];
}


}
class Solution
{
    public static void Main(string[] args)
    {
        RunTestCases();
    }

    public static void RunTestCases()
    {
        var testCases = new List<(List<int> input, int expectedOutput)>
        {
            (new List<int> { 1, 1, 2, 2, 3 }, 3),
            (new List<int> { 4, 9, 95, 93, 57, 4, 57 }, 95),
            (new List<int> { 100, 200, 100 }, 200),
            (new List<int> { 42 }, 42),
            (new List<int> { 0, 1, 0, 2, 1, 2, 3, 4, 4 }, 3)
        };

        foreach (var (input, expected) in testCases)
        {
            int result = Result.lonelyinteger(input);
            Console.WriteLine($"Input: {string.Join(" ", input)}");
            Console.WriteLine($"Expected Output: {expected}");
            Console.WriteLine($"Actual Output: {result}");
            Console.WriteLine(result == expected ? "Test Passed" : "Test Failed");
            Console.WriteLine();
        }
    }
}
