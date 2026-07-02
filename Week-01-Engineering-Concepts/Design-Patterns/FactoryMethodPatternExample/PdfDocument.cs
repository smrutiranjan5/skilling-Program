using System;
using System.Collections.Generic;
using System.Text;



namespace FactoryMethodPatternExample
{
    internal class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document");
        }
    }
}