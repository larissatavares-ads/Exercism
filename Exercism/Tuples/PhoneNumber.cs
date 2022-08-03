using System;
using System.Collections.Generic;
using System.Text;

namespace Exercism.Tuples
{
    public class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string[] x = phoneNumber.Split("-");
            var a = x[0];
            var b = x[1];
            var c = x[2];

            if (a == "212")
            {
                Console.WriteLine("Você está em NY");
            }
            else Console.WriteLine("Você não está em NY");
            if (b == "555")
            {
                Console.WriteLine("Número fake");
            }
            else Console.WriteLine("Número correto");

            var t1 = $"{a}";
            var t2 = $"{b}";
            var t3 = $"{c}";

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            return (false, true, c);
            
        }
    }
}
