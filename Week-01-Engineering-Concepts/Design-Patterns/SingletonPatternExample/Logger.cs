using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternExample
{
    internal class Logger
    {
        private static Logger instance;

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }
}