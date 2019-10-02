// Author: Hayden Migliore
// Date: August 5, 2019
// Problem: Given an array of integers, return an new
//      array such that each element at index i of the
//      new array is the product of all of the numbers
//      in the original array except the one at i. For
//      exampe if our input was [1, 2, 3, 4, 5] the
//      output woudl be [120, 60, 40, 30, 24]. If our
//      input was [3, 2, 1], the expected output would
//      be [2, 3, 6]. Follow-up: waht if you can't use
//      division?

using System;

namespace DCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intialize variables
            Console.WriteLine("Set size of array.");
            int i = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            int[] set = new int[i];
            int[] answer = new int[i];

            //Create Set through Console
            Console.WriteLine("Please enter " + i + " numbers for set.");
            for (int j = 0; j < i; j++)
            {
                set[j] = Convert.ToInt32(Console.ReadLine());
            }

            //Process new set
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k < i; k++)
                {
                    if (k != j)
                        sum = sum * set[k];
                }
                answer[j] = sum;
                sum = 1;
            }

            //Output new set
            Console.WriteLine("The ouput is ");
            for (int j = 0; j < i; j++)
            {
                Console.Write(answer[j] + " ");
            }
        }
    }
}
