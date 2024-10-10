using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems_Challenge_Run
{



    internal class MinMaxSum
    {

        class Result
        {

            /*
             * Complete the 'miniMaxSum' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            // Given five positive integers
            // find the max and min
            // sum each possible value in array
            // with each other
            // so 5 possible answers
            //then find the min and max of that
            // loop through array
            // print output into two seperate lines
            //


            public static void miniMaxSum(List<int> arr)
            {

                int MaxSum = 0;
                int MinSum = 0;
                int CurrentSum = 0;

                int sum = 0;
                for (int i=0; i < arr.Count; i++)
                {
                    sum += arr[i];
                    //sum = sum + arr[4];
                    //Console.WriteLine(sum);
                    //sum -= arr[4];



                }
                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[1]);
                Console.WriteLine(arr[2]);
                //so what im doing is minusing each element by one sum.
                // sum -= arr[5]
                int sum1 = sum - arr[4];
                int sum2 = sum - arr[3];
                int sum3 = sum - arr[2];
                int sum4 = sum - arr[1];
                int sum5 = sum - arr[0];
                Console.WriteLine($"Sum1={sum1}\nSum2={sum2}\nSum3={sum3}\nSum4={sum4}\nSum5={sum5}");
                List<int> SumofValues = new List<int> { sum1, sum2, sum3, sum4, sum5 };
                int MaxValue = SumofValues.Max();
                int MinValue = SumofValues.Min();


                Console.WriteLine(sum);
                Console.WriteLine($"This is the max integer{MaxValue}\nThis is the min sum{MinValue}");



            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                List<int> testInput = new List<int> { 1, 2, 3, 4, 5 };
                Result.miniMaxSum(testInput);



            }
        }
    }


}
