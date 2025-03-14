using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomValidationAttributeAndExtensionMethod.Helpers
{
    public class IsEligibleForVote : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int age = Convert.ToInt32(value);
            if(age < 18)
            {
                return new ValidationResult("Not Eligible for Vote");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class AgeInRange : ValidationAttribute
    {
        private readonly string errorMessage;
        public AgeInRange(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int age = Convert.ToInt32(value);
            if(age < 18 || age > 50)
            {
                return new ValidationResult(errorMessage);
            }  
            else
            {
                return ValidationResult.Success;
            }
        } 
    }
    public class AgeInFuture : ValidationAttribute
    {
        private readonly string _errorMessage;
        public AgeInFuture(string errorMessage)
        {
            _errorMessage = errorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            DateTime date = Convert.ToDateTime(value);
            if(date > DateTime.UtcNow)
            {
                return new ValidationResult(_errorMessage);
            }
            else
            {
                return ValidationResult.Success;
            }
        } 
    }
}