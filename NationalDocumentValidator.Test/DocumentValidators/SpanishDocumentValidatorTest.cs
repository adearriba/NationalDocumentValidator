using NationalDocumentValidator.DocumentValidators;
using NUnit.Framework;

namespace NationalDocumentValidator.Test.DocumentValidators
{
    public class SpanishDocumentValidatorTest
    {

        [Test]
        public void Test1()
        {
            var validator = DocumentValidatorFactory.GetValidator("ESP");
            bool result = false;

            result = validator.Validate("73028195K");
            Assert.IsTrue(result);

            result = validator.Validate("73028195S");
            Assert.IsFalse(result);

            result = validator.Validate("0073028195S");
            Assert.IsFalse(result);

            result = validator.Validate("XDC320109");
            Assert.IsTrue(result);

            result = validator.Validate("XD320109234");
            Assert.IsFalse(result);
        }
    }
}