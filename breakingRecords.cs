using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'breakingRecords' function below.
     *
    
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        // Initialize maxScore and minScore to the first score
        int maxScore = scores[0], minScore = scores[0];
        
        // Counters for record-breaking occurrences
        int maxScoreCounter = 0;
        int minScoreCounter = 0;
        
        // Loop through scores starting from the second game
        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
                maxScoreCounter++; // add when new max is found
            }
            else if (scores[i] < minScore)
            {
                minScore = scores[i];
                minScoreCounter++; // add when new min is found
            }
        }
        
=        return new List<int> { maxScoreCounter, minScoreCounter };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Test Case 1
        List<int> scores1 = new List<int> { 12, 24, 10, 24 };  // Expected Output: [1, 1]
        List<int> result1 = Result.breakingRecords(scores1);
        Console.WriteLine("Input: " + string.Join(", ", scores1) + " -> Output: " + string.Join(", ", result1));

        // Test Case 2
        List<int> scores2 = new List<int> { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };  // Expected Output: [4, 0]
        List<int> result2 = Result.breakingRecords(scores2);
        Console.WriteLine("Input: " + string.Join(", ", scores2) + " -> Output: " + string.Join(", ", result2));
    }
}
