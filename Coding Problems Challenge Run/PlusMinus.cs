using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems_Challenge_Run
{
    internal class PlusMinus
    {
        class Result
        {

            /*
             * Complete the 'plusMinus' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void plusMinus(List<int> arr)
            {
                /*
                We are goign to have one variable for a count of the array
                one for how many times a positive number appears
                one for how many times a negative number appears
                and lastly one for any that is zero.
                */

                int Arrcount = arr.Count();
                int PosCount = 0;
                int NegCount = 0;
                int ZeroCount = 0;

                // Next we need to loop throught the array.
                // This will be done through a for each loop.

                foreach (int num in arr)
                {
                    if (num > 0)
                    {
                        PosCount++;
                    }
                    else if (num < 0)
                    {
                        NegCount++;
                    }
                    else
                    {
                        ZeroCount++;
                    }
                }
                // Calculating The ratios
                double PosRatio = (double)PosCount / Arrcount;
                double NegRatio = (double)NegCount / Arrcount;
                double ZeroRatio = (double)ZeroCount / Arrcount;

                Console.WriteLine($"This is the positive ratio {PosRatio}");
                Console.WriteLine($"This is the negative ratio {NegRatio}");
                Console.WriteLine($"This is the zero ratio {ZeroRatio}");
            }

        }

        class Solution
        {
            /*
            public static void Main(string[] args)
            {
                //int n = Convert.ToInt32(Console.ReadLine().Trim());

                //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                // Test case 1
                List<int> testArray1 = new List<int> { -4, 3, -9, 0, 4, 1 };
                Console.WriteLine("Test Case 1:");
                Result.plusMinus(testArray1);

                // Test case 2
                List<int> testArray2 = new List<int> { 1, 1, 0, -1, -1 };
                Console.WriteLine("\nTest Case 2:");
                Result.plusMinus(testArray2);

                // Test case 3
                List<int> testArray3 = new List<int> { 0, 0, 0 };
                Console.WriteLine("\nTest Case 3:");
                Result.plusMinus(testArray3);
               // Result.plusMinus(arr);
                Console.WriteLine($"This is the negative ratio");

            }
        }
*/
        }


    }
}
