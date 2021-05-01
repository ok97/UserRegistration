using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User_Registration_Problem;

namespace UnitTestUserRegistrationProblem
{
    /* UC13:- Refactor the Code to use Lambda Function to validate User Entry
              - Use Lambda Function to validate First Name, Last Name, Email, Mobile, and Password
    */
    [TestClass]
    public class UnitTest1
    {
        
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
        [DataRow("omp", "Invalid User Details")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("ok", "Invalid User Details")]
        [DataRow(".dfgjs", "Invalid User Details")]
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
        [DataRow(".@gmail.com", "Invalid User Details")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("abc123@.com.com", "Invalid User Details")]
        [DataRow("abc.@gmail.com", "Invalid User Details")]
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
        [DataRow("12", "Invalid User Details")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("123456789", "Invalid User Details")]
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
        [DataRow("AB", "Invalid User Details")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("ABCSD", "Invalid User Details")]
        [DataRow("123456Ac", "Invalid User Details")]
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
        [DataRow("14abcde", "Invalid User Details")]
        [DataRow("123456Ac", "Invalid User Details")]
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
        [DataRow("abcde", "Invalid User Details")]
        [DataRow("Ac", "Invalid User Details")]
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
         [DataRow("abcde", "Invalid User Details")]
        [DataRow("Ac", "Invalid User Details")]
        [DataRow("12345678", "Invalid User Details")]
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
        [DataRow(".@gmail.com abc123@.com.com abc.@gmail.com", "Invalid User Details")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
       
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