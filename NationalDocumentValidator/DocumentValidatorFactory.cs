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
                case Countries.USA:
                    return new UnitedStatesValidator();
                default:
                    return new DefaultValidator();
            }
        }
    }
}
