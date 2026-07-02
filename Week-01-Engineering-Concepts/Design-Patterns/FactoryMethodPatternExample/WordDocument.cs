using System;
using System.Collections.Generic;
using System.Text;



namespace FactoryMethodPatternExample
{
    internal class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document");
        }
    }
}