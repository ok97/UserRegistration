using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User_Registration_Problem;

namespace UnitTestUserRegistrationProblem
{
    [TestClass]
    public class UnitTest1
    {
        /*  UC1:- As a User need to enter a valid First Name - First name starts with Cap and has minimum 3 characters
         */
        [TestMethod]
        [DataRow("Omp", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("Omprakash", true)]
        public void UnitTestPatternValidation_ValidName(string FirstName, bool expected)
        {
            string FirstNamePattern = @"^[A-Z][a-z ]{2,}$"; //Define Pattern
            bool actual = Program.PatternValidation(FirstName, FirstNamePattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }

        //Invalid Names
        [TestMethod]
        [DataRow("omp", "Invalid")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("ok", "Invalid")]
        [DataRow(".dfgjs", "Invalid")]
        public void UnitTestPatternValidation_InvalidName(string FirstName, string expected)
        {
            try
            {
                string FirstNamePattern = @"^[A-Z][a-z ]{2,}$";  //Define Pattern
                Program.PatternValidation(FirstName, FirstNamePattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }

        }


        /*  UC3:- As a User need to enter a valid email - E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts 
                  (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions
         */
        [TestMethod]
        [DataRow("omkhawshi@gmail.com", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("abc-100@yahoo.com", true)]
        [DataRow("abc.xyz@bl.co.in", true)]
        //[DataRow("abc.@gmail.com", true)]
        public void UnitTestPatternValidation_ValidEmail(string Email, bool expected)
        {
            string Epattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$"; //Define Pattern
            bool actual = Program.PatternValidation(Email, Epattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }


        //Invalid Email
        [TestMethod]
        [DataRow(".@gmail.com", "Invalid")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("abc123@.com.com", "Invalid")]
        [DataRow("abc.@gmail.com", "Invalid")]
        public void UnitTestPatternValidation_InvalidEmail(string Email, string expected)
        {
            try
            {
                string Epattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$"; //Define Pattern
                bool actual = Program.PatternValidation(Email, Epattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }

        }

        /*  UC4:- As a User need to follow pre -defined Mobile Format 
                  - E.g. 919919819801 - Country code follow by space and 10 digit number
   */
        [TestMethod]
        [DataRow("+918788616249", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("8788616249", true)]
        [DataRow("919919819801", true)]
        // [DataRow("878849", true)]      
        public void UnitTestPatternValidation_ValidPhoneNumber(string Phone, bool expected)
        {
            string Phonepattern = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"; //Define Pattern 
            bool actual = Program.PatternValidation(Phone, Phonepattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }


        // Invalid Phone Number
        [TestMethod]
        [DataRow("12", "Invalid")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("123456789", "Invalid")]
        public void UnitTestPatternValidation_InValidPhoneNumber(string Phone, string expected)
        {
            try
            {
                string Phonepattern = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"; //Define Pattern 
                bool actual = Program.PatternValidation(Phone, Phonepattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }
        }


        /*  UC5:- As a User need to follow pre-defined Password rules.
                  Rule1 – minimum 8 Characters 
                  - NOTE – All rules must be passed
           */
        [TestMethod]
        [DataRow("abcdefgh", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method

        public void UnitTestPatternValidation_ValidPassword(string Password, bool expected)
        {

            string Passwordpattern = @"[a-z]+"; //Define Pattern @"[A-Z]+"

            bool actual = Program.PatternValidation(Password, Passwordpattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }


        // Invalid Password
        [TestMethod]
        [DataRow("AB", "Invalid")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("ABCSD", "Invalid")]
        [DataRow("123456Ac", "Invalid")]
        public void UnitTestPatternValidation_InValidPassword(string Phone, string expected)
        {
            try
            {
                string Passwordpattern = @"[a-z]+"; //Define Pattern 
                bool actual = Program.PatternValidation(Phone, Passwordpattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }
        }

        /* UC6:- As a User need to follow pre-defined Password rules.
                 Rule2 – Should have at least 1 Upper Case.
         */
        [TestMethod]
        [DataRow("Hello", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method

        public void UnitTestPatternValidation_ValidPasswordRule2(string Password, bool expected)
        {

            string Passwordpattern = @"(?=.*[a-z])(?=.*[A-Z])"; //Define Pattern @"[A-Z]+"

            bool actual = Program.PatternValidation(Password, Passwordpattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }

        // Invalid Password
        [TestMethod]
        [DataRow("14abcde", "Invalid")]
        [DataRow("123456Ac", "Invalid")]
        public void UnitTestPatternValidation_InValidPasswordRule2(string Phone, string expected)
        {
            try
            {
                string Passwordpattern = @"(?=.*[a-z])(?=.*[A-Z])"; //Define Pattern 
                bool actual = Program.PatternValidation(Phone, Passwordpattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }
        }
        /* UC6:- As a User need to follow pre-defined Password rules.
                 - Rule3 – Should have at least 1 numeric number in the password.
         */
        [TestMethod]
        [DataRow("Hello1", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("14Aabcde", true)]
        public void UnitTestPatternValidation_ValidPasswordRule3(string Password, bool expected)
        {
            string Passwordpattern = @"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])"; //Define Pattern @"[A-Z]+"

            bool actual = Program.PatternValidation(Password, Passwordpattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }

        // Invalid Password
        [TestMethod]
        [DataRow("abcde", "Invalid")]
        [DataRow("Ac", "Invalid")]
        public void UnitTestPatternValidation_InValidPasswordRule3(string Phone, string expected)
        {
            try
            {
                string Passwordpattern = @"(?=.*[a-z])(?=.*[A-Z])"; //Define Pattern 
                bool actual = Program.PatternValidation(Phone, Passwordpattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }
        }

        /* UC7:- As a User need to follow pre-defined Password rules.
                 - Rule4 – Has exactly 1 Special Character 
                 NOTE – All rules must be passed
        */
        [TestMethod]
        [DataRow("Hello world$123", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("123Aa$Aa", true)]
        [DataRow("123Aa$Aa", true)]

        public void UnitTestPatternValidation_ValidPasswordRule4(string Password, bool expected)
        {
            string Passwordpattern = @"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=\[{\]};:<>|./?,-])"; //Define Pattern @"[A-Z]+"

            bool actual = Program.PatternValidation(Password, Passwordpattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }

        // Invalid Password
        [TestMethod]
         [DataRow("abcde", "Invalid")]
        [DataRow("Ac", "Invalid")]
        [DataRow("12345678", "Invalid")]
        public void UnitTestPatternValidation_InValidPasswordRule4(string Phone, string expected)
        {
            try
            {
                string Passwordpattern = @"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=\[{\]};:<>|./?,-])"; //Define Pattern @"[A-Z]+"
                bool actual = Program.PatternValidation(Phone, Passwordpattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.

            }
        }



        /* UC11:- Write JUnit  Parameterised Test to  validate multiple entry for the Email Address. 
         */
        //Invalid Email
        [TestMethod]
        [DataRow(".@gmail.com abc123@.com.com abc.@gmail.com", "Invalid")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
       
        public void UnitTestPatternValidation_InvalidEmailmultipleentry(string Email, string expected)
        {
            try
            {
                string Epattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$"; //Define Pattern
                bool actual = Program.PatternValidation(Email, Epattern); //passing parameter
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }

        }

    }
}