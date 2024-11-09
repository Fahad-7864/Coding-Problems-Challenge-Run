// Online C# Editor for free


using System;


class Result
{
    /*
     * The function 'flippingBits' flips all bits of a 32-bit unsigned integer.
     */
    public static long flippingBits(long n)
    {
        // Perform XOR with 0xFFFFFFFF to flip all bits of a 32-bit unsigned integer
        return n ^ 0xFFFFFFFF;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Read the number of test cases
        Console.WriteLine("Enter the number of test cases:");
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine("Enter the values:");
        for (int i = 0; i < q; i++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());
            long result = Result.flippingBits(n);
            Console.WriteLine($"Flipped result for {n}: {result}");
        }

        RunCustomTests();
    }

    public static void RunCustomTests()
    {
        Console.WriteLine("\nRunning custom test cases...");

        // Custom Test Case 1
        long input1 = 4294967295; 
        long expected1 = 0;       
        Console.WriteLine($"Input: {input1}, Expected: {expected1}, Actual: {Result.flippingBits(input1)}");

        // Custom Test Case 2
        long input2 = 0;          // All bits set to 0
        long expected2 = 4294967295; // All bits flipped to 1
        Console.WriteLine($"Input: {input2}, Expected: {expected2}, Actual: {Result.flippingBits(input2)}");

        // Custom Test Case 3
        long input3 = 123456789;  // Random number
        long expected3 = 4171510506;
        Console.WriteLine($"Input: {input3}, Expected: {expected3}, Actual: {Result.flippingBits(input3)}");

        // Custom Test Case 4
        long input4 = 4294967294; // All bits except the least significant one set to 1
        long expected4 = 1;      
        Console.WriteLine($"Input: {input4}, Expected: {expected4}, Actual: {Result.flippingBits(input4)}");
    }
}
