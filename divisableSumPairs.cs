// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        // What we need to do is make a target variable, loop through each index in the arrray, see which pairs add to each other and is a modulus of K. if it is then the pair is incremented and it is returned through the number of pairs we have.
        int counter=0;
        
        for (int i = 0; i <ar.Count; i ++){
            for (int j = i+1; j < ar.Count; j++){
                if ((ar[i]+ar[j])%k==0){
                counter++;
                Console.WriteLine("Counter Incremented");
                }
                
            }
        }
        return counter; 
        }

    
class Solution
{
    public static void Main(string[] args)
    {
        // Test Case 1: Basic example case
        Console.WriteLine("Test Case 1");
        int result1 = Result.divisibleSumPairs(6, 3, new List<int> { 1, 3, 2, 6, 1, 2 });
        Console.WriteLine($"Expected: 5, Actual: {result1}\n");

        // Test Case 2: All elements identical
        Console.WriteLine("Test Case 2");
        int result2 = Result.divisibleSumPairs(5, 2, new List<int> { 2, 2, 2, 2, 2 });
        Console.WriteLine($"Expected: 10, Actual: {result2}\n");

        // Test Case 3: No valid pairs
        Console.WriteLine("Test Case 3");
        int result3 = Result.divisibleSumPairs(4, 5, new List<int> { 1, 2, 3, 4 });
        Console.WriteLine($"Expected: 0, Actual: {result3}\n");

        // Test Case 4: Minimum input edge case
        Console.WriteLine("Test Case 4");
        int result4 = Result.divisibleSumPairs(2, 3, new List<int> { 1, 2 });
        Console.WriteLine($"Expected: 0, Actual: {result4}\n");
    }
}
}
