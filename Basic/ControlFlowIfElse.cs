using System;
using CSharpCourse.Common;

namespace CSharpCourse.Basic
{
    class ControlFlowIfElse
    {

        // Write a program and ask the user to enter a number. The number should be between 1 to 10. 
        // If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        public static void ExerciseOne()
        {
            Console.WriteLine("Enter a number:");
            var numberRaw = Console.ReadLine();
            var number = CommonMethods.ValidateNumber(numberRaw);
            Console.WriteLine("Your number is {0}", 
                (number <= 10 || number >= 0) ? "Valid" : "Invalid");
        }


        // Write a program which takes two numbers from the console and displays the maximum of the two.
        public static void ExerciseTwo()
        {
            Console.WriteLine("Enter first number");
            var firstNumberRaw = Console.ReadLine();
            var firstNumber = CommonMethods.ValidateNumber(firstNumberRaw);
            Console.WriteLine("Enter second number");
            var secondNumberRaw = Console.ReadLine();
            var secondNumber = CommonMethods.ValidateNumber(secondNumberRaw);
            Console.WriteLine("The bigest number is: {0}", 
                (firstNumber > secondNumber) ? firstNumber : secondNumber);
        }

        // Write a program and ask the user to enter the width and height of an image.
        // Then tell if the image is landscape or portrait.
        public static void ExerciseThree()
        {
            Console.WriteLine("Enter width");
            var widthRaw = Console.ReadLine();
            var width = CommonMethods.ValidateNumber(widthRaw);
            Console.WriteLine("Enter height");
            var heightRaw = Console.ReadLine();
            var height = CommonMethods.ValidateNumber(heightRaw);
            Console.WriteLine("Your picture is a {0}", 
                (width > height) ? "Landscape" : "Portrait");
        }

        // Your job is to write a program for a speed camera.
        // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        // Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
        // If the user enters a value less than the speed limit, program should display Ok on the console.
        // If the value is above the speed limit, the program should calculate the number of demerit points.
        // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        // If the number of demerit points is above 12, the program should display License Suspended.
        public static void ExerciseFour()
        {
            Console.WriteLine("Enter speed limit");
            var speedLimitRaw = Console.ReadLine();
            var speedLimit = CommonMethods.ValidateNumber(speedLimitRaw);
            Console.WriteLine("Enter car speed");
            var carSpeedRaw = Console.ReadLine();
            var carSpeed = CommonMethods.ValidateNumber(carSpeedRaw);
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

    }
}
