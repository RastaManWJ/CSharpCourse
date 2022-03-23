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
            try
            {
                result = Int32.Parse(number);
            }
            catch (Exception)
            {
                Console.WriteLine("Your input is not a number");
            }
            return result;
        }
    }
}
