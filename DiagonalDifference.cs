using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count;
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i][i];
            secondaryDiagonalSum += arr[i][n - i - 1];
        }

        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Custom Test Cases
        RunTest(new List<List<int>> 
        {
            new List<int> {11, 2, 4},
            new List<int> {4, 5, 6},
            new List<int> {10, 8, -12}
        }, 15);  // Expected output: 15

        RunTest(new List<List<int>> 
        {
            new List<int> {1, 2, 3},
            new List<int> {4, 5, 6},
            new List<int> {7, 8, 9}
        }, 0);  // Expected output: 0

        RunTest(new List<List<int>> 
        {
            new List<int> {6, 1, 1},
            new List<int> {1, 7, 1},
            new List<int> {1, 1, 8}
        }, 11);  // Expected output: 11

        RunTest(new List<List<int>> 
        {
            new List<int> {1, 0, 1},
            new List<int> {0, 1, 0},
            new List<int> {1, 0, 1}
        }, 0);  // Expected output: 0
    }

    // Helper method to run test cases
    private static void RunTest(List<List<int>> arr, int expected)
    {
        int result = Result.diagonalDifference(arr);
        Console.WriteLine("Input Matrix:");
        foreach (var row in arr)
        {
            Console.WriteLine(string.Join(" ", row));
        }
        Console.WriteLine($"Expected Output: {expected}");
        Console.WriteLine($"Actual Output: {result}");
        Console.WriteLine(result == expected ? "Test Passed\n" : "Test Failed\n");
    }
}
