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
        /* UC12:- Refactor the Code to throw customexceptions in case of Invalid User Details 
                  - Rewrite all Test Cases to take in Custom Exception for Invalid First Name, Last Name, Email, Mobile, and Password
        */
        public static bool PatternValidation(String input, String pattern)
        {

            Regex regex = new Regex(pattern);  //create object of the Regex class (its Regesx predefine class)
            bool match = regex.IsMatch(input) ? true : throw new InvalidDataException("Invalid User Details");
            return match;

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
