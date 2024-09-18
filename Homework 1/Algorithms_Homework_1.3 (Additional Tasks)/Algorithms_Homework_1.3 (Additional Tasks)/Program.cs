using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms_Homework_1._3__Additional_Tasks_
{
    internal class Program
    {
        static void Main(string[] args)
        {




//--------------------------------------------------------------------------------------------------
//Print all elements of the list.
            List<int> list = new List<int>() {1, 2, 3, 4, 5};

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


//--------------------------------------------------------------------------------------------------
//From a three-digit number (e.g., 124), print the largest digit.

            int number  = 124;
            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;

            int largestDigit = Math.Max(digit1, Math.Max(digit2, digit3));
            Console.WriteLine(largestDigit);

//--------------------------------------------------------------------------------------------------
//From a three - digit number(e.g., 124), print the smallest digit.

            int SmallestDigit = Math.Min(digit1, Math.Min(digit2,digit3));
            Console.WriteLine(SmallestDigit);


//--------------------------------------------------------------------------------------------------
//From an array, find all even values and print their sum.

            int[] arr = new int[6];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;

            foreach (var i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


//--------------------------------------------------------------------------------------------------
//Calculate and print the average of all elements in the array.

            int Sum = 0;
            int Step = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
                Step++;
            }

            double average = (double)Sum / Step; 
            Console.WriteLine($"Average: {average}");

        }
    }
}
