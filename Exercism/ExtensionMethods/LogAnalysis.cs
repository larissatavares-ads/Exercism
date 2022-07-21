using System;
using System.Collections.Generic;
using System.Text;

namespace Exercism.ExtensionMethods
{
    static class LogAnalysis
    {
        public static string SubstringAfter(this string logLevel, string v)
        {
            int indexOfSpace = logLevel.IndexOf(v) + v.Length;
            string logName = logLevel.Substring(indexOfSpace, logLevel.Length - indexOfSpace);
            Console.WriteLine(logName);
            return logName;
        }
        public static string SubstringBetween(this string logLevel, string x, string y)
        {
            int indexOfSpace_1 = logLevel.IndexOf(x);
            int indexOfSpace_2 = logLevel.IndexOf(y);
            string logName = logLevel.Substring(indexOfSpace_1 + x.Length, ((indexOfSpace_2 - y.Length) - x.Length)+1);
            Console.WriteLine(logName);
            return logName;
        }
        public static string Message(this string logLevel)
        {
            int indexOfSpace = logLevel.IndexOf(": ") + 2;
            string logName = logLevel.Substring(indexOfSpace, logLevel.Length - indexOfSpace);
            Console.WriteLine(logName);
            return logName;
        }
        public static string LogLevel(this string logLevel)
        {
            int indexOfSpace_1 = logLevel.IndexOf("[");
            int indexOfSpace_2 = logLevel.IndexOf("]");
            string logName = logLevel.Substring(indexOfSpace_1 + 1, (indexOfSpace_2 - 1) - indexOfSpace_1);
            Console.WriteLine(logName);
            return logName;
        }
    }
}
