using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NationalDocumentValidator.DocumentValidators
{
    public class SpainValidator : IDocumentValidator
    {
        public bool IsValid(string document)
        {
            document = document.ToUpper().Replace(" ", "");
            if (ValidateNIForNIE(document)) return true;
            if (ValidatePassport(document)) return true;

            return false;
        }

        private bool ValidateNIForNIE(string document)
        {
            string validChars = "TRWAGMYFPDXBNJZSQVHLCKET";
            Regex regexNIF = new Regex("^[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKET]$");
            Regex regexNIE = new Regex("^[XYZ][0-9]{7}[TRWAGMYFPDXBNJZSQVHLCKET]$");

            bool isValidNIF = regexNIF.IsMatch(document);
            bool isValidNIE = regexNIE.IsMatch(document);
            if (!isValidNIF && !isValidNIE) return false;

            char letter = document[document.Length-1];
            if (isValidNIE)
            {
                document = Regex.Replace(document, "[X]", "0");
                document = Regex.Replace(document, "[Y]", "1");
                document = Regex.Replace(document, "[Z]", "2");
            }

            int num = Int32.Parse(document.Substring(0, document.Length - 1));
            int charIndex = num % 23;

            if (letter == validChars[charIndex]) return true;
            return false;
        }

        private bool ValidatePassport(string document)
        {
            Regex regexPassport = new Regex("^[A-Z]{3}[0-9]{6}[A-Z]?$");
            return regexPassport.IsMatch(document);
        }
    }
}
