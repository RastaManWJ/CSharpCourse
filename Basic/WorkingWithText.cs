using System;
using System.Collections.Generic;

namespace CSharpCourse.Basic
{
    class WorkingWithText
    {
        //Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive.
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
        //display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public static void ExerciseOne()
        {
            var numbers = AskForHyphenStr();
            var numbersList = ConvertHyphenStrToIntList(numbers);
            var isAscending = 0;
            if (numbersList[0] == numbersList[1] + 1)
                isAscending = 1;
            else if (numbersList[0] == numbersList[1] - 1)
                isAscending = -1;
            else
            {
                Console.WriteLine("Not Consecutive");
                return;
            }

            for (var i = 0; i < numbersList.Count-1; i++)
            {
                if (numbersList[i] == numbersList[i + 1] + isAscending)
                    continue;
                else
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
            }
            Console.WriteLine("Your string was Consecutive!");
        }

        //Write a program and ask the user to enter a few numbers separated by a hyphen.
        //If the user simply presses Enter, without supplying an input, exit immediately;
        //otherwise, check to see if there are duplicates.
        //If so, display "Duplicate" on the console.
        public static void ExerciseTwo()
        {
            var numbers = AskForHyphenStr();
            if (string.IsNullOrEmpty(numbers))
                return;
            var numbersList = ConvertHyphenStrToIntList(numbers);
            for(var i=0; i < numbersList.Count-1; i++)
            {
                for(var j=i+1; j<numbersList.Count; j++)
                {
                    if (numbersList[i] == numbersList[j])
                    {
                        Console.WriteLine("Duplicate found!");
                        return;
                    }
                }
            }
            Console.WriteLine("Your list didn't contain duplicates!");
        }

        //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        //A valid time should be between 00:00 and 23:59.
        //If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        //If the user doesn't provide any values, consider it as invalid time.
        public static void ExerciseThree()
        {
            //TODO
        }

        //Write a program and ask the user to enter a few words separated by a space.
        //Use the words to create a variable name with PascalCase.
        //For example, if the user types: "number of students", display "NumberOfStudents".
        //Make sure that the program is not dependent on the input.
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public static void ExerciseFour()
        {
            //TODO
        }

        //Write a program and ask the user to enter an English word.
        //Count the number of vowels (a, e, o, u, i) in the word.
        //So, if the user enters "inadequate", the program should display 6 on the console.
        public static void ExerciseFive()
        {
            //TODO
        }

        static string AskForHyphenStr()
        {
            Console.WriteLine("Please enter list of numbers separated by hyphen:");
            var numbers = Console.ReadLine();
            return numbers;
        }

        static List<int> ConvertHyphenStrToIntList(string hyphen)
        {
            var numbersList = new List<int>();
            foreach (var number in hyphen.Split('-'))
            {
                numbersList.Add(Convert.ToInt32(number));
            }
            return numbersList;
        }
    }
}
