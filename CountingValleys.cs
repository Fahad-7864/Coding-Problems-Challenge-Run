using System;
using System.IO;

class Result
{
    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */
    public static int countingValleys(int steps, string path)
    {
        int altitude = 0;
        int valleys = 0;
        bool inValley = false;

        foreach (char step in path)
        {
            if (step == 'U')
            {
                altitude++;
            }
            else if (step == 'D')
            {
                altitude--;
            }

            if (altitude < 0 && !inValley)
            {
                inValley = true;
            }

            if (altitude == 0 && inValley)
            {
                valleys++;
                inValley = false;
            }
        }

        return valleys;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Custom test case 1
        int steps1 = 8;
        string path1 = "UDDDUDUU";
        Console.WriteLine("Test Case 1:");
        Console.WriteLine($"Input: steps = {steps1}, path = \"{path1}\"");
        Console.WriteLine("Expected Output: 1");
        Console.WriteLine("Actual Output: " + Result.countingValleys(steps1, path1));
        Console.WriteLine();

        // Custom test case 2
        int steps2 = 12;
        string path2 = "DDUUDDUDUUUD";
        Console.WriteLine("Test Case 2:");
        Console.WriteLine($"Input: steps = {steps2}, path = \"{path2}\"");
        Console.WriteLine("Expected Output: 2");
        Console.WriteLine("Actual Output: " + Result.countingValleys(steps2, path2));
        Console.WriteLine();

        // Custom test case 3
        int steps3 = 10;
        string path3 = "DUDDDUUDUU";
        Console.WriteLine("Test Case 3:");
        Console.WriteLine($"Input: steps = {steps3}, path = \"{path3}\"");
        Console.WriteLine("Expected Output: 1");
        Console.WriteLine("Actual Output: " + Result.countingValleys(steps3, path3));
        Console.WriteLine();

        // Custom test case 4 - Edge case with no valleys
        int steps4 = 4;
        string path4 = "UUUU";
        Console.WriteLine("Test Case 4:");
        Console.WriteLine($"Input: steps = {steps4}, path = \"{path4}\"");
        Console.WriteLine("Expected Output: 0");
        Console.WriteLine("Actual Output: " + Result.countingValleys(steps4, path4));
        Console.WriteLine();
    }
}
