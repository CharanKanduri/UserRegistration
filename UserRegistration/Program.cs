using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName,eMail,phoneNumber,passWord;
            Console.WriteLine("Welcome to User Registration");
            firstName=GetUserInformation.FirstName();
            secondName=GetUserInformation.SecondName();
            eMail = GetUserInformation.EMail();
            phoneNumber = GetUserInformation.PhoneNumber();
            passWord = GetUserInformation.PassWord();

        }
    }
}
