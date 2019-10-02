// Author: Hayden Migliore
// Date: August 1, 2019
// Problem: Given a list of numbers and a number k, 
//      return whether any two numbers form the list 
//      add up to k. For example, given [10, 15, 3, 7] 
//      and k of 17, return true since 10 + 7 is 17. 
// Bonus: Can you do this in one pass? 

using System;

namespace DCP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intialize variables
            Boolean addition = false;
            int[] set = new int[5];

            //Create Set through Console
            Console.WriteLine("Please enter 5 numbers for set.");
            set[0] = Convert.ToInt32(Console.ReadLine());
            set[1] = Convert.ToInt32(Console.ReadLine());
            set[2] = Convert.ToInt32(Console.ReadLine());
            set[3] = Convert.ToInt32(Console.ReadLine());
            set[4] = Convert.ToInt32(Console.ReadLine());

            //Create k through Console
            Console.WriteLine("Please enter K.");
            int k = Convert.ToInt32(Console.ReadLine());

            //Test set and K
            if (set[0] + set[1] == k)
                addition = true;
            else if (set[0] + set[2] == k)
                addition = true;
            else if (set[0] + set[3] == k)
                addition = true;
            else if (set[0] + set[4] == k)
                addition = true;
            else if (set[1] + set[2] == k)
                addition = true;
            else if (set[1] + set[3] == k)
                addition = true;
            else if (set[1] + set[4] == k)
                addition = true;
            else if (set[2] + set[3] == k)
                addition = true;
            else if (set[2] + set[4] == k)
                addition = true;
            else if (set[3] + set[4] == k)
                addition = true;

            //Output
            Console.WriteLine("Output is: " + addition);
        }
    }
}

