using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternExample
{
    internal class TestLogger
    {
        public static void Test()
        {
            Logger logger1 = Logger.GetInstance();

            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application Started");
            logger2.Log("Logging from second reference");

            if (logger1 == logger2)
            {
                Console.WriteLine("Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("Multiple Logger instances exist.");
            }
        }
    }
}