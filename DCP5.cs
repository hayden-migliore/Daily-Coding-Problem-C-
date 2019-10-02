// Author: Hayden Migliore
// Date: August 6, 2019
// Problem: cons(a, b) constructs a pair, and car(pair) 
// and cdr(pair) returns the first and last element of 
// that pair. For example, car(cons(3, 4)) returns 3, 
// and cdr(cons(3, 4)) returns 4.

using System;

namespace DCP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get values from Console
            Console.WriteLine("Enter two values.");
            Object value1 = Console.ReadLine();
            Object value2 = Console.ReadLine();

            //Output
            Pair p = Cons(value1, value2);
            Console.WriteLine(String.Concat("The result of Cons is ", p.toString()));
            Console.WriteLine("The result of Car is " + Car(p));
            Console.WriteLine("The result of Cdr is " + Cdr(p));
        }

        static Pair Cons(Object first, Object second)
        {
            Pair p = new Pair(first, second);
            return p;
        }

        static Object Car(Pair p)
        {
            return p.getFirst();
        }

        static Object Cdr(Pair p)
        {
            return p.getSecond();
        }
    }

    public class Pair
    {
        //Intalize variables
        private Object first;
        private Object second;

        //Constructor
        public Pair(Object first, Object second)
        {
            this.first = first;
            this.second = second;
        }

        //Get First
        public Object getFirst()
        {
            return first;
        }

        //Get Second
        public Object getSecond()
        {
            return second;
        }

        //ToString
        public String toString()
        {
            return first.ToString() + ", " + second.ToString();
        }
    }
}
