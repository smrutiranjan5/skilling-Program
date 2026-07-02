using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    internal class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}