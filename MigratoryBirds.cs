using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> birdCounts = new Dictionary<int, int>();

        foreach (int bird in arr)
        {
            if (birdCounts.ContainsKey(bird))
            {
                birdCounts[bird]++;
            }
            else
            {
                birdCounts[bird] = 1;
            }
        }

        // Find the bird type with the maximum count, if there's a tie, select the smallest ID
        int maxCount = 0;
        int resultBirdType = int.MaxValue;

        foreach (var kvp in birdCounts)
        {
            if (kvp.Value > maxCount || (kvp.Value == maxCount && kvp.Key < resultBirdType))
            {
                maxCount = kvp.Value;
                resultBirdType = kvp.Key;
            }
        }

        return resultBirdType;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Custom Test Cases
        RunTest(new List<int> {1, 1, 2, 2, 3}, 1);  // Expected output: 1
        RunTest(new List<int> {1, 4, 4, 4, 5, 3}, 4);  // Expected output: 4
        RunTest(new List<int> {5, 5, 5, 1, 1, 2, 2, 3, 3, 3}, 5);  // Expected output: 5
        RunTest(new List<int> {2, 2, 2, 3, 3, 3, 1, 1, 1, 4, 4, 4, 5}, 1);  // Expected output: 1
    }

    private static void RunTest(List<int> arr, int expected)
    {
        int result = Result.migratoryBirds(arr);
        Console.WriteLine($"Input Array: {string.Join(" ", arr)}");
        Console.WriteLine($"Expected Output: {expected}");
        Console.WriteLine($"Actual Output: {result}");
        Console.WriteLine(result == expected ? "Test Passed\n" : "Test Failed\n");
    }
}
