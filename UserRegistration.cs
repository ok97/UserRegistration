using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{  /*  UC1:- As a User need to enter a valid First Name - First name starts with Cap and has minimum 3 characters
   */
    class UserRegistration
    {

        public static bool NameValidation(String firstName)
        {
            String pattern = "^[A-Z]{1}[a-z]{2,}$";  //Define Pattern

            Regex regex = new Regex(pattern);      //create object of the Regex class (its Regesx predefine class)
            return regex.IsMatch(firstName);     //match in a specified input string 
        }
        static void Main(string[] args)  //Main Method
        {
            Console.WriteLine("Welcome to User Registration");   //Print message       

            Console.WriteLine("Enter the First Name");  //Take user input
            String firstName = Console.ReadLine();     //Store input string veriable

            if (NameValidation(firstName))  //Check firstname NameValidation method
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }

        }
    }

}