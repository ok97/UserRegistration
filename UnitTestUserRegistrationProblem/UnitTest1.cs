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
        [DataRow("omp", "Invalid")]
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






    }
}
