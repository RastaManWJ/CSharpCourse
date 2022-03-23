using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Common
{
    class CommonMethods
    {
        public static int ValidateNumber(string number)
        {
            var result = 0;
            var numberIsValid = false;
            while (!numberIsValid)
            {
                if (int.TryParse(number, out result))
                    numberIsValid = true;
                else
                {
                    Console.WriteLine("Your number is not Valid. Try again!");
                    number = Console.ReadLine();
                }

            }
            return result;
        }
    }
}
