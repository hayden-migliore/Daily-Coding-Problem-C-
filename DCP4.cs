// Author: Hayden Migliore
// Date: August 5, 2019
// Problem: Given an array of integers, find the first 
// missing positive integer in linear time and constant 
// space. In other words, find the lowest positive integer 
// that does not exist in the array. The array can contain 
// duplicates and negative numbers as well. For example, 
// the input [3, 4, -1, 1] should give 2. The input 
// [1, 2, 0] should give 3.

using System;

namespace DCP4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get size of sets
            Console.WriteLine("Set size of Array");
            int i = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            int[] set = new int[i];
            int[] answer = new int[i];
            bool inArray = false;

            //Create Set through Console
            Console.WriteLine("Please enter " + i + " numbers for set.");
            for (int j = 0; j < i; j++)
            {
                set[j] = Convert.ToInt32(Console.ReadLine());
            }

            //Fine lowest missing integer
            for (int j = 1; j < 20; j++)
            {
                for (int k = 0; k < i; k++)
                {
                    if (set[k] == j)
                        inArray = true;
                }
                if (!inArray)
                {
                    Console.WriteLine("Output is " + j);
                    break;
                }
                inArray = false;
            }
        }
    }
}
