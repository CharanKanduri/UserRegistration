using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class GetUserInformation
    {
        public static string FirstName()
        {   //User input
            Console.WriteLine("\nEnter the First Name : ");
            string firstName;

            //Defining Regex for user's FirstName
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");

            while (true)
            {
                firstName = Console.ReadLine();
                if (regex.IsMatch(firstName))
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("\nPlease Enter Valid FirstName");
                }
            }
            Console.WriteLine("\nYour First Name is {0}", firstName);
            return firstName;
        }

        public static string SecondName()
        {   //User input
            Console.WriteLine("\nEnter the Second Name : ");
            string secondName;

            //Defining Regex for user's FirstName
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");

            while (true)
            {
                secondName = Console.ReadLine();
                if (regex.IsMatch(secondName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid FirstName");
                }
            }
            Console.WriteLine("\nYour Second Name is {0}", secondName);
            return secondName;
        }

        public static string EMail()
        {   //User input
            Console.WriteLine("\nEnter the E-Mail ID : ");
            string eMail;

            //Defining Regex for user's FirstName
            Regex eMailRegex = new Regex(@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");

            while (true)
            {
                eMail = Console.ReadLine();
                if (eMailRegex.IsMatch(eMail))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid E-Mail ID");
                }
            }
            Console.WriteLine("\nYour Second Name is {0}", eMail);
            return eMail;
        }

        public static string PhoneNumber()
        {   //User input
            Console.WriteLine("\nEnter Phone number along with country code : ");
            string phoneNumber;

            //Defining Regex for Phonenumber
            Regex phoneNumberRegex = new Regex(@"^[0-9]+\s[0-9]{10}$");

            while (true)
            {
                phoneNumber = Console.ReadLine();
                if (phoneNumberRegex.IsMatch(phoneNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid Phone Number");
                }
            }
            Console.WriteLine("\nYour PhoneNUmber is {0}", phoneNumber);
            return phoneNumber;
        }
        public static string PassWord()
        {   //User input
            Console.WriteLine("\nEnter password : ");
            string passWord;

          

            //Defining Regex for password with 8 length and atleast one Uppercase and one digit RULE-III
            Regex passWordRegex = new Regex(@"^(?=.*[0-9])(?=.*[A-Z]).{8,}$");

            while (true)
            {
                passWord = Console.ReadLine();
                if (passWordRegex.IsMatch(passWord))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid passWord");
                }
            }
            Console.WriteLine("\nYour passWord is {0}", passWord);
            return passWord;
        }
    }
}
