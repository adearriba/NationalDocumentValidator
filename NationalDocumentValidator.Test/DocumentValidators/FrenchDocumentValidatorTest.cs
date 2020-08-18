using NationalDocumentValidator.DocumentValidators;
using NUnit.Framework;

namespace NationalDocumentValidator.Test.DocumentValidators
{
    public class FrenchDocumentValidatorTest
    {

        [Test]
        public void Test1()
        {
            var validator = DocumentValidatorFactory.GetValidator("FRA");
            bool result = false;

            result = validator.Validate("180126955222380");
            Assert.IsTrue(result);

            result = validator.Validate("180126955222381");
            Assert.IsFalse(result);

            result = validator.Validate("78TH67845");
            Assert.IsTrue(result);

            result = validator.Validate("783TH67845");
            Assert.IsFalse(result);

            result = validator.Validate("34HJ76894");
            Assert.IsTrue(result);

            result = validator.Validate("A2GH89056");
            Assert.IsFalse(result);
        }
    }
}