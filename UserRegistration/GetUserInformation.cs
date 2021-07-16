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
    }
}
