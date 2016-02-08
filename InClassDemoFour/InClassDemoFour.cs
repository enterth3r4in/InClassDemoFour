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
            Console.Write("Enter a name: ");

            /***
            int firstNumber = 0, secondNumber = 0, examScore = 0;
            double firstDouble = 0.0, secondDouble = 0.0;
            string myName, yourName;
            ***/
            /***
            Console.Write("Enter an integer: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter another integer: ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine(firstNumber.ToString() + " = " + secondNumber.ToString());
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber.ToString() + " > " + secondNumber.ToString());
            }
            else
            {
                Console.WriteLine(firstNumber.ToString() + " < " + secondNumber.ToString());
            }

            Console.Write("Enter a double: ");
            firstDouble = double.Parse(Console.ReadLine());

            Console.Write("Enter another double: ");
            secondDouble = double.Parse(Console.ReadLine());

            if (firstDouble == secondDouble)
            {
                Console.WriteLine(firstDouble.ToString() + " = " + secondDouble.ToString());
            }
            else if (firstDouble > secondDouble)
            {
                Console.WriteLine(firstDouble.ToString() + " > " + secondDouble.ToString());
            }
            else
            {
                Console.WriteLine(firstDouble.ToString() + " < " + secondDouble.ToString());
            }
            

            Console.Write("Enter an exam score [0-100]: ");
            examScore = int.Parse(Console.ReadLine());

            if(examScore >= 90)
            {
                Console.WriteLine("A");
            }
            else if(examScore >= 80)
            {
                Console.WriteLine("B");
            }
            else if(examScore >= 70)
            {
                Console.WriteLine("C");
            }
            else if(examScore >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
            //Name + score, name + score, First name received grade, second name received grade

            Console.Write("Enter my name: ");
            myName = Console.ReadLine();

            Console.Write("Enter your name: ");
            yourName = Console.ReadLine();

            Console.WriteLine(myName.CompareTo(yourName));

            if(myName == yourName)
            {
                Console.WriteLine("Wow, that is weird.");
            }
            else
            {
                Console.WriteLine("We are humans.");
            }


            Console.WriteLine("Program Done.");
            ***/
        }
    }
}
