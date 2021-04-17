using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{  /*  UC3:- As a User need to enter a valid email - E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts 
       (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions
   */
    class UserRegistration
    {
        public static bool EmailValidation(String email)
        {
            String Epattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$"; //Define Email Pattern
            Regex eregex = new Regex(Epattern); //create object of the Regex class (its Regesx predefine class)
            return eregex.IsMatch(Epattern);

        }
        public static bool NameValidation(String firstName)
        {
            String pattern = "^[A-Z]{1}[a-z]{2,}$";  //Define Pattern
            

            Regex regex = new Regex(pattern);      //create object of the Regex class (its Regesx predefine class)
            return regex.IsMatch(firstName);         //match in a specified input string and  return value
        }
        static void Main(string[] args)    //Main Method
        {
            Console.WriteLine("Welcome to User Registration!");   //Print message             

            Console.WriteLine("Enter the First Name"); //Take user input
            String firstName = Console.ReadLine();     //Store input string veriable
            if (NameValidation(firstName))           //Check firstname NameValidation method
            {
                Console.WriteLine("Valid First Name"); //Print message input valid
            }
            else
            {
                Console.WriteLine("Invalid First Name"); //print Firstname Invalid
            }

            Console.WriteLine("\nEnter the Last Name"); // Take user input
            String lastName = Console.ReadLine();             //Store input string veriable

            if (NameValidation(lastName))             //Check lastName NameValidation method
            {
                Console.WriteLine("Valid Last Name");   //Print message input valid
            }
            else
            {
                Console.WriteLine("Invalid Last Name");  //print Lastname Invalid
            }
            
            Console.WriteLine("Enter Email:- ");  // Take user input
            string email = Console.ReadLine();      //Store input string veriable

            if (EmailValidation(email))    //Check email NameValidation method
            {
                Console.WriteLine("Valid Email");  //Print message input valid
            }
            else
            {
                Console.WriteLine("Invalid Email");  //print Email Invalid
            }
                
            



        }
        
    }

}