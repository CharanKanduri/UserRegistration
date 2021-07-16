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

        public static void GetDetails()
        {
            string firstName;
            string secondName;
            string eMail;
            string phoneNumber;
            string passWord;
            Console.WriteLine("\nEnter the First Name : ");
            firstName = Console.ReadLine();
            FirstName(firstName);

            Console.WriteLine("\nEnter the Second Name : ");
            secondName= Console.ReadLine();
            SecondName(secondName);

            Console.WriteLine("\nEnter the E-Mail ID : ");
            eMail = Console.ReadLine();
            EMail(eMail);

            Console.WriteLine("\nEnter Phone number along with country code : ");
            phoneNumber = Console.ReadLine();
            PhoneNumber(phoneNumber);

            Console.WriteLine("\nEnter password : ");
            passWord = Console.ReadLine();
            PassWord(passWord);

        }

        public static string FirstName(string firstName)
        { 
            //Defining Regex for user's FirstName
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");

            while (true)
            {
                
                if (regex.IsMatch(firstName))
                {
                    return firstName;
                }
                else 
                {
                    Console.WriteLine("\nPlease Enter Valid FirstName");
                    return null;
                }
            }
           
            
        }

        public static string SecondName(string secondName)
        {  
            

            //Defining Regex for user's FirstName
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");

            while (true)
            {
                
                if (regex.IsMatch(secondName))
                {
                    return secondName;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid FirstName");
                    return null;
                }
            }
            
            
        }

        public static string EMail(string eMail)
        {  
            

            //Defining Regex for user's FirstName
            Regex eMailRegex = new Regex(@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");

            while (true)
            {
                
                if (eMailRegex.IsMatch(eMail))
                {
                    return eMail;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid E-Mail ID");
                    return null;
                }
            }
            
        }

        public static string PhoneNumber(string phoneNumber)
        {   
            //Defining Regex for Phonenumber
            Regex phoneNumberRegex = new Regex(@"^[0-9]+\s[0-9]{10}$");

            while (true)
            {
               
                if (phoneNumberRegex.IsMatch(phoneNumber))
                {
                    return phoneNumber;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid Phone Number");
                    return null;
                }
            }
           
            
        }
        public static string PassWord(string passWord)
        {  
        
            //Defining Regex for password with 8 length and atleast one Uppercase and one digit RULE and one special Char RULE -IV
            Regex passWordRegex = new Regex(@"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8}$");
            while (true)
            {
                
                if (passWordRegex.IsMatch(passWord))
                {
                    return passWord;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid passWord");
                    return null;
                }
            }
            
           
        }
    }
}
