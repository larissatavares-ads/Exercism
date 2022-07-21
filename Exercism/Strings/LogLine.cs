using System;
using System.Collections.Generic;
using System.Text;

namespace Exercism.Strings
{
    public class LogLine
    {
        public static string Message(string logLine)
        {
            string[] subs = logLine.Split(':');
            var x = $"{subs[1]}";
            Console.WriteLine(x.Trim());
            return x;
        }
        public static string LogLevel(string logLine)
        {
            string[] subs = logLine.Split('[', ']');
            var x = $"{subs[1]}";
            Console.WriteLine(x.ToLower());
            return x;
        }
        public static string Reformat(string logLine)
        {
            string[] subs = logLine.Split(":");
            var x = $"{subs[1]}";
            var y = $" {subs[0]}";
            y = y.Replace('[', '(').Replace(']', ')');
            Console.WriteLine(x.Trim() + y.ToLower());
            return x + y;
        }
    }
}
