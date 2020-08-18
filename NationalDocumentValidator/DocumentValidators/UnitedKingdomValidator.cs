using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NationalDocumentValidator.DocumentValidators
{
    public class UnitedKingdomValidator : IDocumentValidator
    {
        public bool IsValid(string document)
        {
            document = document.ToUpper().Replace(" ", "");
            if (ValidateNINO(document)) return true;
            if (ValidatePassport(document)) return true;

            return false;
        }

        public bool ValidateNINO(string document)
        {
            Regex ninoRegex = new Regex(@"^(?<prefix>[ABCEGHJKLMNOPRSTWXYZ][ABCEGHJKLMNPRSTWXYZ])(?<sequence>[0-9]{6})(?<letter>[ABCDFMP])$");

            var match = ninoRegex.Match(document);
            if (!match.Success) return false;

            var prefix = match.Groups["prefix"].Value;
            var notUsedPrefix = new string[] { "BG", "GB", "KN", "NK", "NT", "TN", "ZZ" };

            if (notUsedPrefix.Contains(prefix)) return false;

            return true;
        }

        public bool ValidatePassport(string document)
        {
            Regex regex = new Regex(@"^\d{9}$");
            return regex.IsMatch(document);
        }
    }
}
