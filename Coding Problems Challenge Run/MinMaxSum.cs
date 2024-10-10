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

            public static void miniMaxSum(List<int> arr)
            {

            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                long sum = arr.Sum(i => (long)i);
                long min = sum - arr.Max();
                long max = sum - arr.Min();
                Console.WriteLine($"{min} {max}");
                Console.WriteLine("HIIII");

                //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                //Result.miniMaxSum(arr);
            }
        }
    }


}
