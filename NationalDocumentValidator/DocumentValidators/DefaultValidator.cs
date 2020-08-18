using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDocumentValidator.DocumentValidators
{
    public class DefaultValidator : IDocumentValidator
    {
        public bool Validate(string document)
        {
            throw new ArgumentException($"There is no validator for the ISO value provided.");
        }
    }
}
