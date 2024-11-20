using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */
    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        sticks.Sort();

        // go through the array from the end to find the largest triangle
        for (int i = sticks.Count - 3; i >= 0; i--)
        {
            int a = sticks[i];
            int b = sticks[i + 1];
            int c = sticks[i + 2];

            // Check if the triplet can form a triangle
            if (a + b > c)
            {
                return new List<int> { a, b, c };
            }
        }

        // If no triangle can be formed, return -1
        return new List<int> { -1 };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        RunTest(new List<int> { 1, 1, 1, 3, 3 }, new List<int> { 1, 3, 3 }); // Expected output: [1, 3, 3]
        RunTest(new List<int> { 1, 2, 3 }, new List<int> { -1 });            // Expected output: [-1]
        RunTest(new List<int> { 6, 10, 15, 20, 25 }, new List<int> { 15, 20, 25 }); // Expected output: [15, 20, 25]
        RunTest(new List<int> { 2, 2, 4 }, new List<int> { -1 });           // Expected output: [-1]
    }

    private static void RunTest(List<int> sticks, List<int> expected)
    {
        List<int> result = Result.maximumPerimeterTriangle(sticks);
        Console.WriteLine($"Input Sticks: {string.Join(" ", sticks)}");
        Console.WriteLine($"Expected Output: {string.Join(" ", expected)}");
        Console.WriteLine($"Actual Output: {string.Join(" ", result)}");
        Console.WriteLine(result.SequenceEqual(expected) ? "Test Passed\n" : "Test Failed\n");
    }
}
