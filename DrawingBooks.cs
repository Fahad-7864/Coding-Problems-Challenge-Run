using System;
using System.IO;

class Result
{
    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n (total number of pages)
     *  2. INTEGER p (target page)
     */
    public static int pageCount(int n, int p)
    {
        // Calculate pages turned from the front
        int fromFront = p / 2;

        // Calculate pages turned from the back
        int fromBack = (n / 2) - (p / 2);

        // Return the minimum
        return Math.Min(fromFront, fromBack);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim()); // Total pages in the book
        int p = Convert.ToInt32(Console.ReadLine().Trim()); // Target page to turn to

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
