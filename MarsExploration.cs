// Online C# Editor for free
using System;
using System.IO;

class Result
{
    /*
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */
    public static int marsExploration(string s)
    {
        int alteredCount = 0;
        string sosPattern = "SOS";
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != sosPattern[i % 3])
            {
                alteredCount++;
            }
        }
        
        return alteredCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Custom Test Cases
        RunTest("SOSSPSSQSSOR", 3);  
        RunTest("SOSSOT", 1);       
        RunTest("SOSSOSSOSSOS", 0); 
        RunTest("SOSSPSSQSSOSSOT", 4); 
    }

    private static void RunTest(string input, int expected)
    {
        int result = Result.marsExploration(input);
        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Expected Output: {expected}");
        Console.WriteLine($"Actual Output: {result}");
        Console.WriteLine(result == expected ? "Test Passed\n" : "Test Failed\n");
    }
}
