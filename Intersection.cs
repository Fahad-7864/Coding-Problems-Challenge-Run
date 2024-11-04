using System;
using System.Collections.Generic;

class MainClass {
    public static string FindIntersection(string[] strArr) {
        // Split each element in the array into a list of integers
        string[] firstArray = strArr[0].Split(',');
        string[] secondArray = strArr[1].Split(',');

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        // conv each element in firstArray to an integer and add to firstList
        foreach (string num in firstArray) {
            firstList.Add(int.Parse(num.Trim())); 
        }

        foreach (string num in secondArray) {
            secondList.Add(int.Parse(num.Trim()));
        }

        // Find the intersection 
        List<int> intersection = new List<int>();
        foreach (int num in firstList) {
            if (secondList.Contains(num)) {
                intersection.Add(num);
            }
        }

        intersection.Sort();

        // Return the result as a comma-separated string or "false" if no intersection
        if (intersection.Count > 0) {
            return string.Join(",", intersection);
        } else {
            return "false";
        }
    }

    static void Main() {
        // Example usage
        string[] strArr = { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
        Console.WriteLine(FindIntersection(strArr));  // Output: "1,4,13"
    }
}
