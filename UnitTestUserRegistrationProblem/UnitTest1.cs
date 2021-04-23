using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User_Registration_Problem;

namespace UnitTestUserRegistrationProblem
{
    [TestClass]
    public class UnitTest1
    {
        // Valid Names 
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


        // Valid Email 
        [TestMethod]
        [DataRow("omkhawshi@gmail.com", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("abc-100@yahoo.com", true)]
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

        // Valid Phone Number
        [TestMethod]
        [DataRow("+918788616249", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("8788616249", true)]
        //[DataRow("abc.@gmail.com", true)]
        public void UnitTestPatternValidation_ValidPhoneNumber(string Phone, bool expected)
        {
            string Phonepattern = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"; //Define Pattern 
            bool actual = Program.PatternValidation(Phone, Phonepattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }


        // Invalid Phone Number
        [TestMethod]
        [DataRow("12", "Invalid")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("12345", "Invalid")]        
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


    }
}
