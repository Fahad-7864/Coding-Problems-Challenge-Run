// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System;
using System.Collections.Generic;

class Solution
{
    // This method takes a list of integer grades and rounds them according to the grades
    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            int grade = grades[i];
            if (grade >= 38)
            {
                // Calculate the next multiple of 5 for the current grade
                // Divide the grade by 5, add 1, then multiply by 5 to get the next multiple
                int nextMultipleOfFive = ((grade / 5) + 1) * 5;
                // Check if the difference between the grade and the next multiple of 5 is less than 3
                if (nextMultipleOfFive - grade < 3)
                {
                    grades[i] = nextMultipleOfFive;
                }
            }
        }
        return grades;
    }

    static void Main(string[] args)
    {
        // Test case 1: Standard rounding example
        List<int> grades1 = new List<int> { 73, 67, 38, 33 };
        Console.WriteLine("Test Case 1: Input: {73, 67, 38, 33}");
        Console.WriteLine("Expected Output: {75, 67, 40, 33}");
        Console.WriteLine("Actual Output: " + string.Join(", ", gradingStudents(grades1)));

        List<int> grades2 = new List<int> { 40, 45, 50, 55 };
        Console.WriteLine("\nTest Case 2: Input: {40, 45, 50, 55}");
        Console.WriteLine("Expected Output: {40, 45, 50, 55}");
        Console.WriteLine("Actual Output: " + string.Join(", ", gradingStudents(grades2)));

        List<int> grades3 = new List<int> { 10, 20, 30 };
        Console.WriteLine("\nTest Case 3: Input: {10, 20, 30}");
        Console.WriteLine("Expected Output: {10, 20, 30}");
        Console.WriteLine("Actual Output: " + string.Join(", ", gradingStudents(grades3)));

        List<int> grades4 = new List<int> { 39, 41, 44, 84 };
        Console.WriteLine("\nTest Case 4: Input: {39, 41, 44, 84}");
        Console.WriteLine("Expected Output: {39, 41, 45, 85}");
        Console.WriteLine("Actual Output: " + string.Join(", ", gradingStudents(grades4)));

        // Test case 5: All failing grades that should not be rounded
        List<int> grades5 = new List<int> { 32, 37, 29 };
        Console.WriteLine("\nTest Case 5: Input: {32, 37, 29}");
        Console.WriteLine("Expected Output: {32, 37, 29}");
        Console.WriteLine("Actual Output: " + string.Join(", ", gradingStudents(grades5)));
    }
}
