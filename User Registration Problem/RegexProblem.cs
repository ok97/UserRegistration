//using System;
//using System.Text.RegularExpressions;

//namespace User_Registration_Problem
//{
//    class RegexProblem
//    {

//        static void Main(string[] args)
//        {

//            string pattern = "^[0-9]*[a-zA-Z]{3,}[a-zA-Z0-9]*$"; //Define Pattern
//            //string pincode = "^[0-9]{6}$";
//            string pincode = "^[0-9]{3}[ ]*[0-9]{3}$";

//            string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };  // Creating array and store inputs

//            string[] pincodearr = { "123456", "A12345", "12345B", "123B123", "1234567", "400 345", "123 456" }; // Creating array and store PinCodes

//            RegexProblem p = new RegexProblem();  //Object create for the class
//            p.ValidateCharacter(inputs, pattern); //calling
//            p.ValidatePinCode(pincodearr, pincode);//calling
//            Console.ReadLine();

//        }
//        public void ValidateCharacter(string[] arr, string pattern)   // Create Method and passing pattern
//        {
//            Console.WriteLine("Validating 3 conseq Character");
//            Regex regex = new Regex(pattern);   //create object of the Regex class (its Regesx predefine class)
//            IterateLoop(arr, regex);


//        }
//        public void ValidatePinCode(string[] arr, string pincode)  // Create Method and passing Pincode
//        {
//            Console.WriteLine("\nValadating India Postal pin Code");  //Print Pincodes
//            Regex regex = new Regex(pincode);    //create object of the Regex class (its Regesx predefine class)
//            IterateLoop(arr, regex);


//        }
//        public void IterateLoop(string[] arr, Regex regex)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                bool result = regex.IsMatch(arr[i]);  //match in a specified input string and store result
//                if (result)//Cheack Result is match print message 
//                {
//                    Console.WriteLine(arr[i] + "--" + "Valid"); //print message 
//                }
//                else
//                {
//                    Console.WriteLine(arr[i] + "--" + "InValid");//print message result false
//                }
//            }
//        }
//    }
//}
