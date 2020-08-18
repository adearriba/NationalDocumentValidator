using NationalDocumentValidator.DocumentValidators;

namespace NationalDocumentValidator
{
    public class DocumentValidatorFactory
    {
        public static IDocumentValidator GetValidator(Countries country)
        {
            switch (country)
            {
                case Countries.ESP:
                    return new SpainValidator();
                case Countries.FRA:
                    return new FranceValidator();
                case Countries.GBR:
                    return new UnitedKingdomValidator();
                default:
                    return new DefaultValidator();
            }
        }
    }
}
