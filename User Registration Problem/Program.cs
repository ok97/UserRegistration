using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Problem
{
    public class Program
    {
        /* UC13:- Refactor the Code to use Lambda Function to validate User Entry
                  - Use Lambda Function to validate First Name, Last Name, Email, Mobile, and Password
        */
        public static bool PatternValidation(String input, String pattern)
        {
            bool ismatch = false;
            Func<string, string, bool> l = (inp, patt) =>
                 {
                     Regex regex = new Regex(pattern);  //create object of the Regex class (its Regesx predefine class)
                bool match = regex.IsMatch(inp) ? true : throw new InvalidDataException("Invalid User Details");//User Custom Exception
                     return match;
                 };
            ismatch = l(input, pattern);
            return ismatch;
        }

        public static bool CustomexceptionsPatternValidation(String input, String pattern)
        {

            Regex regex = new Regex(pattern);  //create object of the Regex class (its Regesx predefine class)
            bool match = regex.IsMatch(input) ? true : throw new InvalidDataException("Invalid User Details");
            return match;

        }
       



        static void Main(string[] args)
        {
            Console.WriteLine("Unit Test User Registration");
        }
    }
}
