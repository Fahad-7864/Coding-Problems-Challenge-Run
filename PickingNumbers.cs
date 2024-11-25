using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public static int pickingNumbers(List<int> a)
    {
        // Create a frequency array for numbers from 0 to 100
        int[] frequency = new int[101];

        // Populate the frequency array
        foreach (int number in a)
        {
            frequency[number]++;
        }

        int maxLength = 0;

        // Check the sum of adjacent frequencies
        for (int i = 1; i < frequency.Length; i++)
        {
            maxLength = Math.Max(maxLength, frequency[i] + frequency[i - 1]);
        }

        return maxLength;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
