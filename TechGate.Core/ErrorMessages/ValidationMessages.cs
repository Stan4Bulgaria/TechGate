using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGate.Core.ErrorMessages

{
    public static class ValidationMessages
    {
        public const string Required = "This field is required.";
        public const string InvalidPrice = "Price must be greater than 0.";
        public const string InvalidEmail = "Please enter a valid email address.";
        public const string MaxLengthExceeded = "The maximum allowed length is {0} characters.";
        public const string MinLengthRequired = "The minimum allowed length is {0} characters.";

        public const string InvalidAmount = "Invalid Amount";
    }
}
