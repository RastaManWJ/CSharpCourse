using System;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
        }



        // Write a program and ask the user to enter a number. The number should be between 1 to 10. 
        // If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        static void ExerciseOne()
        {
            Console.WriteLine("Enter a number:");
            var raw_input = Console.ReadLine();
            var input = validateNumber(raw_input);
            var result = (input <= 10 || input >= 0) ? "Valid" : "Invalid";
            Console.WriteLine("Your number is {0}", result);
        }


        // Write a program which takes two numbers from the console and displays the maximum of the two.
        static void ExerciseTwo()
        {
            Console.WriteLine("Enter first number");
            var numberOne_raw = Console.ReadLine();
            var numberOne = validateNumber(numberOne_raw);
            Console.WriteLine("Enter second number");
            var numberTwo_raw = Console.ReadLine();
            var numberTwo = validateNumber(numberTwo_raw);
            var result = (numberOne > numberTwo) ? numberOne : numberTwo;
            Console.WriteLine("The bigest number is: {0}", result);
        }

        // Write a program and ask the user to enter the width and height of an image.
        // Then tell if the image is landscape or portrait.
        static void ExerciseThree()
        {
            Console.WriteLine("Enter width");
            var numberOne_raw = Console.ReadLine();
            var numberOne = validateNumber(numberOne_raw);
            Console.WriteLine("Enter height");
            var numberTwo_raw = Console.ReadLine();
            var numberTwo = validateNumber(numberTwo_raw);
            var result = (numberOne > numberTwo) ? "Landscape" : "Portrait";
            Console.WriteLine("Your picture is a {0}", result);
        }

        // Your job is to write a program for a speed camera.
        // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        // Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
        // If the user enters a value less than the speed limit, program should display Ok on the console.
        // If the value is above the speed limit, the program should calculate the number of demerit points.
        // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        // If the number of demerit points is above 12, the program should display License Suspended.
        static void ExerciseFour()
        {
            Console.WriteLine("Enter speed limit");
            var numberOne_raw = Console.ReadLine();
            var speedLimit = validateNumber(numberOne_raw);
            Console.WriteLine("Enter car speed");
            var numberTwo_raw = Console.ReadLine();
            var carSpeed = validateNumber(numberTwo_raw);
            var aboveLimit = carSpeed - speedLimit;
            if (aboveLimit <= 0)
            {
                Console.WriteLine("Your speed is ok");
            }
            else
            {
                var demeritPoints = aboveLimit / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("Your License is Suspended");
                }
                else
                {
                    Console.WriteLine("You got {0} demerit points", demeritPoints);
                }
            }
        }

        static int validateNumber(string number)
        {
            var result = 0;
            try
            {
                result = Int32.Parse(number);
            }
            catch (Exception)
            {
                Console.WriteLine("Your input is not a number");
                Environment.Exit(0);
            }
            return result;
        }
    }
}

