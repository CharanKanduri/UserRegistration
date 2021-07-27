using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using UserRegisteration;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registeration Program!");

            Console.WriteLine("Enter 1-To execute using Regular Expression\nEnter 2-To execute using Annotations");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Call method to Get customer Information
                    GetUserInformation.GetInfo();
                    break;
                case 2:
                    //Create Object for UserDetails Class
                    UserAnnotation userDetails = new UserAnnotation();

                    //Get input from user
                    Console.WriteLine("\nEnter First Name starting with Caps(minimum 3 characters)");
                    string firstname = Console.ReadLine();

                    Console.WriteLine("\nEnter Last Name starting with Caps(minimum 3 characters)");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("\nEnter Email Address");
                    string emails = Console.ReadLine();

                    Console.WriteLine("\nEnter Phone Number of length 10-digit");
                    string phoneNumber = Console.ReadLine();

                    Console.WriteLine("\nEnter Password (minimum 8 characters)");
                    string Password = Console.ReadLine();

                    //Set field Values using Reflection
                    UserAnnotationusingReflection userFirldReflection = new UserAnnotationusingReflection();
                    userFirldReflection.SetFieldValue("FirstName", firstname);
                    userFirldReflection.SetFieldValue("LastName", lastname);
                    userFirldReflection.SetFieldValue("EmailAddress", emails);
                    userFirldReflection.SetFieldValue("PhoneNumber", phoneNumber);
                    userFirldReflection.SetFieldValue("Password", Password);
                    //TestUserRegisteration(userDetails);
                    userFirldReflection.InvokeMethod("TestUserRegisteration");
                    break;
            }
        }
        public static void TestUserRegisteration()
        {
            UserAnnotation userDetails = new UserAnnotation();
            ValidationContext validationContext = new ValidationContext(userDetails, null, null);
            List<ValidationResult> list = new List<ValidationResult>();
            bool check = Validator.TryValidateObject(userDetails, validationContext, list, true);
            if (!check)
            {
                foreach (ValidationResult i in list)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("{0}:", i.MemberNames.First());
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n" + i.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("\n********** USER DETAILS **********");
                Console.WriteLine("FirstName is: {0}", UserAnnotation.FirstName);
                Console.WriteLine("LastName is: {0}", UserAnnotation.LastName);
                Console.WriteLine("Email is: {0}", UserAnnotation.EmailAddress);
                Console.WriteLine("Phone Number is: {0}", UserAnnotation.PhoneNumber);
                Console.WriteLine("Password is: {0}", UserAnnotation.Password);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}