using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NationalDocumentValidator.DocumentValidators
{
    public class FranceValidator : IDocumentValidator
    {
        public bool IsValid(string document)
        {
            document = document.ToUpper().Replace(" ", "");
            if (ValidateSocialNumber(document)) return true;
            if (ValidatePassport(document)) return true;

            return false;
        }

        //Información: https://en.wikipedia.org/wiki/INSEE_code
        private bool ValidateSocialNumber(string document)
        {
            Regex regex = new Regex(@"^(?<gender>[123478])(?<year>\d{2})(?<month>0[1-9]|1[0-2]|[2356789][0-9]|4[0-2])(?<department>\d{2}|2[AB])(?<city>\d{3})(?<certificate>\d{3})(?<key>\d{2})$");

            var match = regex.Match(document);
            if (!match.Success) return false;

            var gender = match.Groups["gender"].Value;
            var year = match.Groups["year"].Value;
            var month = match.Groups["month"].Value;
            var department = match.Groups["department"].Value;
            var city = Int32.Parse(match.Groups["city"].Value);
            var certificate = match.Groups["certificate"].Value;
            var key = Int32.Parse(match.Groups["key"].Value);

            if (certificate == "000") return false;
            if (department == "00") return false;
            if (key == 0 || key > 97) return false;

            var insee = Int64.Parse(gender + year + month + department.Replace("A", "0").Replace("B", "0") + city + certificate);

            return (97 - insee % 97) == key;
        }

        private bool ValidatePassport(string document)
        {
            Regex regexPassport = new Regex("^[0-9]{2}[A-Z]{2}[0-9]{5}$");
            return regexPassport.IsMatch(document);
        }
    }
}
