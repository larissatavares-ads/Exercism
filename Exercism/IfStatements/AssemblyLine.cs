using System;
using System.Collections.Generic;
using System.Text;

namespace Exercism.IfStatements
{
    public class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            /*0: 0% success rate.
              1 to 4: 100% success rate.
              5 to 8: 90% success rate.
              9: 80% success rate.
              10: 77% success rate.*/
            if(speed == 0)
            {
                double p0 = 0.0;
                Console.WriteLine($"{speed}: "+ p0);
                return p0;
            } else if (speed <= 4)
            {
                double p1 = 1.0;
                Console.WriteLine($"{speed}: " + p1);
                return p1;
            } else if (speed <= 8)
            {
                double p2 = 0.9;
                Console.WriteLine($"{speed}: " + p2);
                return p2;
            } else if (speed == 9)
            {
                double p3 = 0.8;
                Console.WriteLine($"{speed}: " + p3);
                return p3;
            } else if (speed == 10)
            {
                double p4 = 0.77;
                Console.WriteLine($"{speed}: " + p4);
                return p4;
            } else return 0;
        }
        public static double ProductionRatePerHour(int speed)
        {
            if (speed == 0)
            {
                double p0 = 0.0*(speed*221);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros: {p0}");
                return p0;
            }
            else if (speed <= 4)
            {
                double p1 = 1.0*(speed*221);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros: {p1}");
                return p1;
            }
            else if (speed <= 8)
            {
                double p2 = 0.9*(speed*221);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros: {p2}"); ;
                return p2;
            }
            else if (speed == 9)
            {
                double p3 = 0.8*(speed*221);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros: {p3}");
                return p3;
            }
            else if (speed == 10)
            {
                double p4 = 0.77*(speed*221);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros: {p4}");
                return p4;
            }
            else return 0;
        }
        public static double WorkingItemsPerMinute(int speed)
        {
            if (speed == 0)
            {
                int p0 = (int)(0.0 * speed * 221/60);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros por min: {p0}");
                return p0;
            }
            else if (speed <= 4)
            {
                int p1 = (int)(1.0 * speed * 221/60);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros por min: {p1}");
                return p1;
            }
            else if (speed <= 8)
            {
                int p2 = (int)(0.9 * speed * 221/60);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros por min: {p2}");
                return p2;
            }
            else if (speed == 9)
            {
                int p3 = (int)(0.8 * speed * 221/60);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros por min: {p3}");
                return p3;
            }
            else if (speed == 10)
            {
                int p4 = (int)(0.77 * speed * 221/60);
                Console.WriteLine($"Horas de produção: {speed} >> Qte de carros por min: {p4}");
                return p4;
            }
            else return 0;
        }
    }
}
