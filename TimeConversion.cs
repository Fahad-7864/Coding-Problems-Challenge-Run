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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

      public static string timeConversion(string s)
    {
        // Your logic here
        int hour = int.Parse(s.Substring(0, 2));  // Extract the hour
        string minuteSecond= s.Substring(2,6);
        Console.WriteLine($"This is{minuteSecond}");
        
        string period = s.Substring(8, 2);  // Extract AM/PM
        
        if (period == "AM" && hour == 12){
            hour = 0;        }
        else if (period == "PM"&& hour != 12){
            hour = hour+12;
        }
        
        string result = ($"{hour:D2}{minuteSecond}");
        return result;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
