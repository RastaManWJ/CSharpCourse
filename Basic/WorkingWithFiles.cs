using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpCourse.Basic
{
    class WorkingWithFiles
    {
        private static readonly string FilePath = Directory.GetCurrentDirectory() + @"\..\..\..\Text.txt";
        //Write a program that reads a text file and displays the number of words.
        public static void ExerciseOne()
        {
            CheckForNecessaryFile();
            var fileTextList = File.ReadAllText(FilePath).Split(' ');
            Console.WriteLine("Your file has {0} words", fileTextList.Length);
        }

        //Write a program that reads a text file and displays the longest word in the file.
        public static void ExerciseTwo()
        {
            CheckForNecessaryFile();
            var fileTextList = File.ReadAllText(FilePath).Split(' ');
            var longestWordIndex = 0;
            var longestWordLenght = 0;
            for(var i = 0; i < fileTextList.Length; i++)
            {
                if (fileTextList[i].Length > longestWordLenght)
                {
                    longestWordIndex = i;
                    longestWordLenght = fileTextList[i].Length;
                }
            }
            Console.WriteLine("Your longest word in the file is: {0}", fileTextList[longestWordIndex]);
        }

        static void CheckForNecessaryFile()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
                Console.WriteLine("You didn't have a file. An empty file was created. Enter a few words in it.");
                return;
            }
        }
    }
}
