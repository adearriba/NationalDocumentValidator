using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NationalDocumentValidator.DocumentValidators
{
    public class UnitedStatesValidator : IDocumentValidator
    {
        public bool IsValid(string document)
        {
            document = document.ToUpper().Replace(" ", "");
            if (ValidateSocialNumber(document)) return true;
            if (ValidatePassport(document)) return true;

            return false;
        }

        private bool ValidateSocialNumber(string document)
        {
            Regex ssnRegex = new Regex(@"^(?<area>[0-9]{2}[1-9])-?(?<group>\d{2})-?(?<serial>\d{4})$");
            return ssnRegex.IsMatch(document);
        }

        private bool ValidatePassport(string document)
        {
            Regex passportRegex = new Regex(@"^([\d|C]\d{5,8})?$");
            return passportRegex.IsMatch(document);
        }
    }
}
