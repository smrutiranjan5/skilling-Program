using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    internal abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}