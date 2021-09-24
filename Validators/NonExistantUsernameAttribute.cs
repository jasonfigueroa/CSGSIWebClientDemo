using CSGSIWebClientDemo.Data;
using CSGSIWebClientDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSGSIWebClientDemo.Validators
{
    public class NonExistantUsernameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            UserLogin userLogin = (UserLogin)validationContext.ObjectInstance;

            APIMessage apiMessage = APIInterface.IsUsernameInDb(userLogin.username).GetAwaiter().GetResult();

            if (apiMessage.Message == "That username is currently available.")
            {
                return new ValidationResult("That username is not currently found in the database");
            }

            return ValidationResult.Success;
        }
    }
}
