using System;

namespace NationalDocumentValidator.DocumentValidators
{
    public class DefaultValidator : IDocumentValidator
    {
        public bool IsValid(string document)
        {
            throw new NotImplementedException($"There is no validator for the ISO value provided.");
        }
    }
}
