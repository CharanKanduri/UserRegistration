using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserRegistration;

namespace UserRegisteration
{
    public class UserAnnotationusingReflection
    {
        public void SetFieldValue(string variableName, string setValue)
        {
            try
            {   //Create object for Class UserDetails
                Type type = typeof(UserAnnotation);
                //Get Property for which value is to be assigned
                PropertyInfo propInfo = type.GetProperty(variableName);
                //Set Value for that Property
                propInfo.SetValue(null, setValue);

            }
            catch (NullReferenceException)
            {
                throw new CustomisedException(CustomisedException.ExceptionType.NVALID_FIELD, "No such field found");
            }
        }
        public string InvokeMethod(string methodname)
        {
            try
            {
                //Create object for Program Class
                Program program = new Program();
                //Get attributes of type Program
                Type type = typeof(UserRegisteration.program);
                //Fetch method from type
                MethodInfo methodInfo = type.GetMethod(methodname);
                //Invoke method
                string method = (string)methodInfo.Invoke(program, null);
                return method;

            }
            catch (NullReferenceException)
            {
                throw new CustomisedException(CustomisedException.ExceptionType.METHOD_NOT_FOUND, "No method found");
            }
        }
    }

    //Class having all user input Properties
    public class UserAnnotation
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"^[A-Z][a-z]{2,}$", ErrorMessage = "Not Valid First Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be of minimum 3 characters and maximum 50")]
        [DataType(DataType.Text)]
        public static string FirstName
        {
            get; set;
        }

        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"^[A-Z][a-z]{2,}$", ErrorMessage = "Not Valid Last Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name should be of minimum 3 characters and maximum 50")]
        [DataType(DataType.Text)]
        public static string LastName
        {
            get; set;
        }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"^[91]+[\s]+[0-9]{10}$", ErrorMessage = "Not a valid Phone Number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number should be of Length 10")]
        [Phone]
        public static string PhoneNumber
        {
            get; set;
        }
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"(^[a-z]+)(([\. \+ \-]?[a-z A-Z 0-9])*)@(([0-9 a-z]+[\.]+[a-z]{3})+([\.]+[a-z]{2,3})?$)", ErrorMessage = "Not a valid Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public static string EmailAddress
        {
            get; set;
        }
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$", ErrorMessage = "Not a valid Password")]
        [DataType(DataType.Password)]
        public static string Password
        {
            get; set;
        }
    }
}