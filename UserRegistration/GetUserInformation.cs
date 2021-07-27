using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class GetUserInformation
    {

        public static string firstname;
        public static string lastname;
        public static string emails;
        public static string phoneNumber;
        private static string Password;
        public static Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
        public static Regex email = new Regex(@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
        public static Regex phone = new Regex(@"^[0-9]+\s[0-9]{10}$");


        public static void GetInfo()
        {

            Console.WriteLine("\nEnter First Name starting with Caps(minimum 3 characters)");
            firstname = Console.ReadLine();
            GetFirstName(firstname);

            Console.WriteLine("\nEnter Last Name starting with Caps(minimum 3 characters)");
            lastname = Console.ReadLine();
            GetLastName(lastname);

            Console.WriteLine("\nEnter Email Address");
            emails = Console.ReadLine();
            GetEmail(emails);

            Console.WriteLine("\nEnter Phone Number in the form (COUNTRY CODE \"Space\" 10-digit PHONE NUMBER)");
            phoneNumber = Console.ReadLine();
            GetPhoneNumber(phoneNumber);


            Console.WriteLine("\nEnter Password (minimum 8 characters)");
            Password = Console.ReadLine();
            GetPassword(Password);

            Display();
        }

        public static void Display()
        {
            Console.WriteLine("\n***********Display User Details**********\n");
            Console.WriteLine("Your First name is: {0}", firstname);
            Console.WriteLine("Your Last name is: {0}", lastname);
            Console.WriteLine("Your Email is: {0}", emails);
            Console.WriteLine("Your Phone number is: {0}", phoneNumber);
            Console.WriteLine("Your password is: {0}", Password);

        }

        //Get First Name from user
        public static string GetFirstName(string firstname)
        {
            try
            {
                if (firstname.Equals(""))
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.EMPTY_MESSAGE, "Please enter a Valid First Name!");
                }
                if (regex.IsMatch(firstname))
                {
                    return firstname;
                }
                else
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid First Name!");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        }
        //Get Last Name from user
        public static string GetLastName(string lastname)
        {
            try
            {
                if (lastname.Equals(""))
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.EMPTY_MESSAGE, "Please enter a Valid Last Name!");
                }
                if (regex.IsMatch(lastname))
                {
                    return lastname;
                }
                else
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid Last Name!");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }

        //Get Email from user
        public static string GetEmail(string emails)
        {
            try
            {
                if (emails.Equals(""))
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.EMPTY_MESSAGE, "Please enter a Valid Email!");
                }
                if (email.IsMatch(emails))
                {
                    return emails;
                }
                else
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid Email!");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        }
        //Get Phone Number from user
        public static string GetPhoneNumber(string phoneNumber)
        {
            try
            {
                if (phoneNumber.Equals(""))
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.EMPTY_MESSAGE, "Please enter a Phone Number!");
                }
                if (phone.IsMatch(phoneNumber))
                {
                    return phoneNumber;
                }
                else
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.EMPTY_MESSAGE, "Please enter a Phone Number!");
                }

            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }


        }
        //Get PassWord from user
        public static string GetPassword(string Password)
        {
            string pattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex passWord = new Regex(pattern);
            try
            {
                if (Password.Equals(""))
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.EMPTY_MESSAGE, "Please enter a Password!");
                }
                if (passWord.IsMatch(Password))
                {
                    return Password;
                }
                else
                {
                    throw new CustomisedException(CustomisedException.ExceptionType.EMPTY_MESSAGE, "Please enter a Password!");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        }
    }
}
