using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            var myNymbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };// Create an int Array and populate numbers 1-10
            var oddNumbers = new List<int>() { 1, 3, 5, 7, 9 };/* Name one List "evens"*/
            //* Name the other List "odds"
            var evenNumbers = new List<int>() { 2, 4, 6, 8, 10 };/* Create two Lists of type int.*/

            foreach(var num in myNymbers)
            {
                if (num %2 == 0)
                {
                    evenNumbers.Add(num);
                    Console.WriteLine($"{num} is an even number!");
                }
                else
                {
                    oddNumbers.Add(num);
                    Console.WriteLine($"{num} is an odd number!");
                }
            }

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
