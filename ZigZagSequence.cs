using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{

    static void findZigZagSequence(List<int> a, int n)
    {
        a.Sort(); 
        int mid = (n - 1) / 2;

        // Swap the middle element with the last element
        int temp = a[mid];
        a[mid] = a[n - 1];
        a[n - 1] = temp;

        // Reverse the second half of the array
        int left = mid + 1;
        int right = n - 2;
        while (left < right)
        {
            temp = a[left];
            a[left] = a[right];
            a[right] = temp;
            left++;
            right--;
        }

        Console.WriteLine(string.Join(" ", a));
    }

      public static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());
        for (int t = 0; t < testCases; t++)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            findZigZagSequence(arr, n);
        }
    }
}
