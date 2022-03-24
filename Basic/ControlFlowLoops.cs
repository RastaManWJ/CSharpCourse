using System;
using CSharpCourse.Common;

namespace CSharpCourse.Basic
{
    class ControlFlowLoops
    {

        // Write a program to count how many numbers between 1 and 100 are
        // divisible by 3 with no remainder. Display the count on the console.
        public static void ExerciseOne()
        {
            Console.Write("How many numbers between 1 and 100 are divisible by 3 with no remainder: ");
            var divisibleCount = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleCount++;
                }
            }
            Console.WriteLine(divisibleCount);
        }

        // Write a program and continuously ask the user to enter a number or "ok" to exit.
        // Calculate the sum of all the previously entered numbers and display it on the console.
        public static void ExerciseTwo()
        {
            while (true)
            {
                Console.WriteLine("Paste a number. Type ok to exit.");
                var answer = Console.ReadLine();
                if(answer == "ok")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(CommonMethods.ValidateNumber(answer));
                }
            }
        }

        // Write a program and ask the user to enter a number.
        // Compute the factorial of the number and print it on the console.
        // For example, if the user enters 5,
        // the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void ExerciseThree()
        {
            Console.WriteLine("Paste a number to calculate factorial.");
            var numberRaw = Console.ReadLine();
            var number = CommonMethods.ValidateNumber(numberRaw);
            Console.WriteLine("Your factorial of {0}! = {1}", number, Factorial(number));
        }

        // Write a program that picks a random number between 1 and 10.
        // Give the user 4 chances to guess the number.
        // If the user guesses the number, display “You won"; otherwise, display “You lost".
        // (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public static void ExerciseFour()
        {
            var random = new Random();
            var number = random.Next(1, 10);
            int Tries = 4;
            for (var i = 0; i < Tries; i++)
            {
                Console.Write("Guess the number from 1 to 10 ({0} tries left): ", Tries - i);
                if (number == CommonMethods.ValidateNumber(Console.ReadLine()))
                {
                    Console.WriteLine("You are correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("You missed");
                }
            }

        }

        //Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console. For example,
        //if the user enters “5, 3, 8, 1, 4", the program should display 8.
        public static void ExerciseFive()
        {
            Console.WriteLine("Enter a series of numbers separated by comma");
            var strOfNumbers = Console.ReadLine();
            if(string.IsNullOrEmpty(strOfNumbers))
                Console.WriteLine("You entered an empty string!");
            else
            {
                var splittedString = strOfNumbers.Split(',');
                var numberList = new int[splittedString.Length];
                for(var i = 0; i < splittedString.Length; i++)
                {
                    numberList[i] = CommonMethods.ValidateNumber(splittedString[i]);
                }
                Console.WriteLine("Max out of your entry is: {0}", GetMax(numberList));
            }
        }

        static int Factorial(int number)
        {
            var result = number;
            if(number < 1)
            {
                result = 0;
                Console.WriteLine("Your number is not positive.");
            }
            else if(number != 1)
            {
                result *= Factorial(number - 1);
            }
            return result;
        }

        static int GetMax(int[] numberList)
        {
            var max = int.MinValue;
            foreach(var number in numberList)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
    }
}
