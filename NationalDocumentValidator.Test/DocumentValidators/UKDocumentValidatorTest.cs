using NationalDocumentValidator.DocumentValidators;
using NUnit.Framework;

namespace NationalDocumentValidator.Test.DocumentValidators
{
    public class UKDocumentValidatorTest
    {

        [Test]
        public void Test1()
        {
            var validator = DocumentValidatorFactory.GetValidator(Countries.GBR);
            bool result = false;

            result = validator.IsValid("123456789");
            Assert.IsTrue(result);

            result = validator.IsValid("12345678A");
            Assert.IsFalse(result);

            result = validator.IsValid("OK 67 68 91 D");
            Assert.IsTrue(result);

            result = validator.IsValid("TL620314C");
            Assert.IsTrue(result);

            result = validator.IsValid("BG620314C");
            Assert.IsFalse(result);

            result = validator.IsValid("KN620314C");
            Assert.IsFalse(result);

            result = validator.IsValid("GB620314C");
            Assert.IsFalse(result);
        }
    }
}