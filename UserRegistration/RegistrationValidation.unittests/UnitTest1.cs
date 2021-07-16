using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace RegistrationValidation.unittests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("Ram", "Ram")]
        [DataRow("Ra", null)]
        [DataRow("charan", null)]
        [DataRow("Charan99", null)]
        public void FirstNameValidation(string a, string e)
        {
            var actual = GetUserInformation.FirstName(a);
            Assert.AreEqual(e, actual);  
        }



        [TestMethod]

        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]
        public void EMailValidation(string a, string e)
        {
            var actual = GetUserInformation.EMail(a);
            Assert.AreEqual(e, actual);
        }
    }
}
