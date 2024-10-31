using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Text;

class Solution {
    static void Main(String[] args) {
        string input;

        // Read input from console until EOF
        while ((input = Console.ReadLine()) != null) {
            Console.WriteLine(ProcessInput(input));
        }
    }

    static string ProcessInput(string input) {
        string[] parts = input.Split(';');
        string operation = parts[0];
        string type = parts[1];
        string text = parts[2];
        StringBuilder result = new StringBuilder();

        if (operation == "S") {
            // Split camel case to space-delimited words
            for (int i = 0; i < text.Length; i++) {
                if (char.IsUpper(text[i]) && i != 0) {
                    result.Append(" ");
                }
                result.Append(char.ToLower(text[i]));
            }
            
            // Remove '()' for method types
            if (type == "M" && result.ToString().EndsWith("()")) {
                result.Length -= 2;
            }
        } else if (operation == "C") {
            // Combine space-delimited words to camel case
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++) {
                if (i == 0 && type != "C") {
                    result.Append(words[i]);
                } else {
                    // CapitaliSe each subsequent word
                    result.Append(char.ToUpper(words[i][0]) + words[i].Substring(1));
                }
            }

            // Add '()' for methods
            if (type == "M") {
                result.Append("()");
            }
        }

        return result.ToString();
    }
}
