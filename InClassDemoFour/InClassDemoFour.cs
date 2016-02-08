using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Cody Miller
 * Assignment: In Class Demo Four
 * Description: Program to demonstrate if statements
 * Inputs: Accepts user input
 * Outputs: Displays output conditionally
 * Testing: run program expected out is varied.
 **/

namespace InClassDemoFour
{
    class InClassDemoFour
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 0;

            Console.Write("Enter an integer: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter another integer: ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
                Console.WriteLine("The numbers are equal.");

            Console.WriteLine("Program Done.");
        }
    }
}
