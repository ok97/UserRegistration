using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{  /*  UC4:- As a User need to follow pre -defined Mobile Format 
       - E.g. 91 9919819801 - Country code follow by space and 10 digit number
   */
    class UserRegistration
    {
        public static bool PhoneNumberValidation(String Pno)
        {
            String PPattern = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"; //Define Phone Number Pattern
            Regex Pregex = new Regex(PPattern); //create object of the Regex class (its Regesx predefine class)
            return Pregex.IsMatch(Pno);
        }
        public static bool EmailValidation(String email)
        {
            String Epattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$"; //Define Email Pattern
            Regex eregex = new Regex(Epattern); //create object of the Regex class (its Regesx predefine class)
            return eregex.IsMatch(email);

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

            Console.WriteLine("\nEnter Email:- ");  // Take user input
            string Epattern = Console.ReadLine();      //Store input string veriable

            if (EmailValidation(Epattern))    //Check email NameValidation method
            {
                Console.WriteLine("Valid Email");  //Print message input valid
            }
            else
            {
                Console.WriteLine("Invalid Email");  //print Email Invalid
            }

            Console.WriteLine("\nEnter Phone Number :- ");  // Take user input
            string Pno = Console.ReadLine();      //Store input string veriable
            if (PhoneNumberValidation(Pno))
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
            }
        }
    }
}