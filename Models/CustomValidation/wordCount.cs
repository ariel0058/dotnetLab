using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelper_annotationLab.Models.CustomValidation
{
    public class wordCount : ValidationAttribute
    {
        private readonly int _max;

        //ProductName does not exceed n words
        //max is function parameter
        public wordCount(int max) : base("{0} contains invalid character.")
        {
            _max = max;
        }

        //value is user input
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {

                int num = value.ToString().Split(' ').Count();
                if (num > _max)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }


    }
}