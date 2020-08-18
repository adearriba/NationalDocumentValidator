using NationalDocumentValidator.DocumentValidators;

namespace NationalDocumentValidator
{
    public class DocumentValidatorFactory
    {
        public static IDocumentValidator GetValidator(string countryISO)
        {
            switch (countryISO)
            {
                case "ESP":
                    return new SpainValidator();
                case "FRA":
                    return new FranceValidator();
                default:
                    return new DefaultValidator();
            }
        }
    }
}
