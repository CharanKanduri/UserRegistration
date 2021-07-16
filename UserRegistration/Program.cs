using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName,eMail;
            Console.WriteLine("Welcome to User Registration");
            firstName=GetUserInformation.FirstName();
            secondName=GetUserInformation.SecondName();
            eMail = GetUserInformation.EMail();
        }
    }
}
