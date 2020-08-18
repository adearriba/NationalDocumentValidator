using System;

namespace NationalDocumentValidator
{
    public interface IDocumentValidator
    {
        public bool Validate(string document);
    }
}
