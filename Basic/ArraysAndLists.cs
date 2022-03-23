using System;
using System.Collections.Generic;
using CSharpCourse.Common;

namespace CSharpCourse.Basic
{
    class ArraysAndLists
    {
        //When you post a message on Facebook, depending on the number
        //of people who like your post, Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays:
        //[Friend 1], [Friend 2] and [Number of Other People] others like your post.

        //Write a program and continuously ask the user to enter different names,
        //until the user presses Enter (without supplying a name).
        //Depending on the number of names provided, display a message based on the above pattern.
        public static void ExerciseOne()
        {
            var listOfNames = GetListOfNames();
            switch (listOfNames.Count)
            {
                case 0:
                    Console.WriteLine("Noone likes you :(");
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", listOfNames[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} likes your post.", listOfNames[0], listOfNames[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post", 
                        listOfNames[0], listOfNames[1], listOfNames.Count - 2);
                    break;
            }
        }

        //Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string.
        //Display the reversed name on the console.
        public static void ExerciseTwo()
        {
            Console.Write("Enter your name: ");
            var userName = Console.ReadLine();
            var userNameCharactes = new List<char>();
            foreach(var letter in userName)
                userNameCharactes.Add(letter);

            userNameCharactes.Reverse();

            foreach(var letter in userNameCharactes)
                Console.Write(letter);
        }

        //Write a program and ask the user to enter 5 numbers.
        //If a number has been previously entered, display an error message and ask the user to re-try. 
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void ExerciseThree()
        {
            Console.WriteLine("Enter 5 unique numbers:");
            var numbers = new List<int>();
            while(numbers.Count != 5)
            {
                var numberRaw = Console.ReadLine();
                var number = CommonMethods.ValidateNumber(numberRaw);
                if(numbers.IndexOf(number) != -1)
                {
                    Console.WriteLine("This is not an unique number!");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates.
        //Display the unique numbers that the user has entered.
        public static void ExerciseFour()
        {
            Console.WriteLine("Enter your numbers or type \"Quit\" to leave");
            var numbers = new List<int>();
            while (true)
            {
                var numberRaw = Console.ReadLine();
                if(numberRaw == "Quit")
                    break;
                var number = CommonMethods.ValidateNumber(numberRaw);
                numbers.Add(number);
            }
            var uniqueNumbers = new List<int>();
            foreach(var number in numbers)
            {
                if (uniqueNumbers.IndexOf(number) == -1)
                    uniqueNumbers.Add(number);
            }
            Console.WriteLine("Your unique number list is: ");
            foreach(var number in uniqueNumbers)
                Console.WriteLine(number);
        }

        //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        //otherwise, display the 3 smallest numbers in the list.
        public static void ExerciseFive()
        {
            var numbersList = new List<int>();
            while (true)
            {
                Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                var numbers = Console.ReadLine();
                if (string.IsNullOrEmpty(numbers) || numbers.Split(',').Length < 5)
                {
                    Console.WriteLine("Your list should contain at least 5 numbers");
                    continue;
                }
                else
                {
                    var tempNumbers = numbers.Split(',');
                    foreach (var number in tempNumbers)
                        numbersList.Add(CommonMethods.ValidateNumber(number));
                    break;
                }
            }
            var smallestNumbers = GetThreeSmallestNumbers(numbersList);
            Console.WriteLine("Your 3 smalles numbers are:");
            foreach (var number in smallestNumbers)
                Console.WriteLine(number);
        }

        static List<string> GetListOfNames()
        {
            var listOfNames = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name of your friend. " +
                    "If your friends list is finished press Enter without typing anything");
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;
                listOfNames.Add(name);
            }
            return listOfNames;
        }

        static int[] GetThreeSmallestNumbers(List<int> numbersList)
        {
            var smallestNumbers = new int[3] { int.MaxValue, int.MaxValue, int.MaxValue };
            numbersList.Sort();
            for(int i = 0; i < numbersList.Count; i++)
                for(int j = 0; j < smallestNumbers.Length; j++)
                {
                    if (numbersList[i] < smallestNumbers[j])
                    {
                        smallestNumbers[j] = numbersList[i];
                        break;
                    }
                }
            return smallestNumbers;
        }
    }
}
