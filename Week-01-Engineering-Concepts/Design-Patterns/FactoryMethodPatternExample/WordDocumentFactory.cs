using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    internal class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }
}