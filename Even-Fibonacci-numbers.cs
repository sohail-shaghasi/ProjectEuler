﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci_Number
{
    // Each new term in the Fibonacci sequence is generated by adding the previous two terms.
    //  By starting with 1 and 2, the first 10 terms will be:
    //   1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    //    By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciProblem();                             //  Calling This method from Main Method.
            Console.ReadLine();                             //  This line is for keeping the console window until the user presses a button.
        }
        public static void FibonacciProblem()               //  The called method.
        {

            List<int> fibonacciEven = new List<int>();      //  Creating a list where the values are stored.
            fibonacciEven.Add(2);                           //  adding a value(digit) to the list named "fibonacciEven".

            int prev = 1;
            int current = 2;
            int temp;
            while (current < 4000000)                     //    The latest number should not be greater than 4000000.
            {
                if ((current + prev) % 2 == 0)           // checking for Even Numbers.
                    fibonacciEven.Add(current + prev);  //  add Even numbers to the list.


                temp = current;
                current = prev + current;               //  Latest number is the addition of two previous numbers.
                prev = temp;
            }
            Console.WriteLine("Solution is : " + fibonacciEven.Sum());  //  getting the sum of total values less than 4000000.
        }
    }
}
