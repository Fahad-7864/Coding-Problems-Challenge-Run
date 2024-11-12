using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static List<int> countingSort(List<int> arr)
    {
        List<int> frequency = new List<int>(new int[100]);

        // Count occurrences of each number in the input array
        foreach (int num in arr)
        {
            frequency[num]++;
        }

        return frequency;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Custom Test Cases
        RunTest(new List<int> {63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33}, 
            "Expected output for each element from 0 to 99 is the frequency count");

        RunTest(new List<int> {1, 1, 1, 1, 1, 1, 1}, 
            "Expected output: Frequency of index 1 should be 7, rest should be 0");

        RunTest(new List<int> {0, 99, 0, 99}, 
            "Expected output: Frequency at index 0 and 99 should be 2, rest should be 0");

        RunTest(new List<int> {10, 10, 10, 20, 20, 20, 30, 30, 30}, 
            "Expected output: Frequency at index 10, 20, 30 should be 3 each, rest should be 0");
    }

    // Helper method to run test cases
    private static void RunTest(List<int> arr, string description)
    {
        List<int> result = Result.countingSort(arr);
        Console.WriteLine($"Test Case: {description}");
        Console.WriteLine($"Input Array: {string.Join(" ", arr)}");
        Console.WriteLine("Output Frequency Array:");
        Console.WriteLine(string.Join(" ", result));
        Console.WriteLine();
    }
}
