using NationalDocumentValidator.DocumentValidators;
using NUnit.Framework;

namespace NationalDocumentValidator.Test.DocumentValidators
{
    public class USADocumentValidatorTest
    {

        [Test]
        public void Test1()
        {
            var validator = DocumentValidatorFactory.GetValidator(Countries.USA);
            bool result = false;

            result = validator.IsValid("423-42-3677");
            Assert.IsTrue(result);

            result = validator.IsValid("618-85-0596");
            Assert.IsTrue(result);

            result = validator.IsValid("085484688");
            Assert.IsTrue(result);

            result = validator.IsValid("000-48-4688");
            Assert.IsFalse(result);

            result = validator.IsValid("0004846880");
            Assert.IsFalse(result);

            result = validator.IsValid("C04846880");
            Assert.IsTrue(result);
        }
    }
}