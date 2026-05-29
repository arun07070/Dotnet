using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Validations
{
    public class NumericIdValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            long result;

            return long.TryParse(value.ToString(), out result);
        }

        public override string FormatErrorMessage(string name)
        {
            return "ID should contain only numeric values";
        }
    }
}