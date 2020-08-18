using NationalDocumentValidator.DocumentValidators;
using NUnit.Framework;

namespace NationalDocumentValidator.Test.DocumentValidators
{
    public class SpanishDocumentValidatorTest
    {

        [Test]
        public void Test1()
        {
            var validator = DocumentValidatorFactory.GetValidator(Countries.ESP);
            bool result = false;

            result = validator.IsValid("36120423G");
            Assert.IsTrue(result);

            result = validator.IsValid("X6599146S");
            Assert.IsFalse(result);

            result = validator.IsValid("0073028195S");
            Assert.IsFalse(result);

            result = validator.IsValid("WVI472287M");
            Assert.IsTrue(result);

            result = validator.IsValid("WV472287M");
            Assert.IsFalse(result);
        }
    }
}