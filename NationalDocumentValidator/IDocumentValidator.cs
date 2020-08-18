using System;

namespace NationalDocumentValidator
{
    public interface IDocumentValidator
    {
        public bool IsValid(string document);
    }
}
