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
        public static void FirstName()
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
        }
    }
}
