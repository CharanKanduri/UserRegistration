using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName;
            Console.WriteLine("Welcome to User Registration");
            firstName=GetUserInformation.FirstName();
            secondName=GetUserInformation.SecondName();
        }
    }
}
