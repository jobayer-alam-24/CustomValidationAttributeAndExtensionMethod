using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CustomValidationAttributeAndExtensionMethod.Helpers;

namespace CustomValidationAttributeAndExtensionMethod.Models
{
    public class Employee
    {
        public string Name { get; set; }

        [IsEligibleForVote, AgeInRange("Age must be less than 50 and above 18")]
        public int Age { get; set; }

        [AgeInFuture("Date of Birth can not be In Future")]
        public DateTime DOB {get; set;}
    }
}