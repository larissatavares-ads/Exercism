using Exercism.Basics;
using Exercism.Booleans;
using Exercism.ExtensionMethods;
using Exercism.IfStatements;
using Exercism.Strings;
using System;

namespace Exercism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssemblyLine.WorkingItemsPerMinute(0);
            AssemblyLine.WorkingItemsPerMinute(1);
            AssemblyLine.WorkingItemsPerMinute(2);
            AssemblyLine.WorkingItemsPerMinute(3);
            AssemblyLine.WorkingItemsPerMinute(4);
            AssemblyLine.WorkingItemsPerMinute(5);
            AssemblyLine.WorkingItemsPerMinute(6);
            AssemblyLine.WorkingItemsPerMinute(7);
            AssemblyLine.WorkingItemsPerMinute(8);
            AssemblyLine.WorkingItemsPerMinute(9);
            AssemblyLine.WorkingItemsPerMinute(10);

            AssemblyLine.ProductionRatePerHour(0);
            AssemblyLine.ProductionRatePerHour(1);
            AssemblyLine.ProductionRatePerHour(2);
            AssemblyLine.ProductionRatePerHour(3);
            AssemblyLine.ProductionRatePerHour(4);
            AssemblyLine.ProductionRatePerHour(5);
            AssemblyLine.ProductionRatePerHour(6);
            AssemblyLine.ProductionRatePerHour(7);
            AssemblyLine.ProductionRatePerHour(8);
            AssemblyLine.ProductionRatePerHour(9);
            AssemblyLine.ProductionRatePerHour(10);

            AssemblyLine.SuccessRate(0);
            AssemblyLine.SuccessRate(1);
            AssemblyLine.SuccessRate(2);
            AssemblyLine.SuccessRate(3);
            AssemblyLine.SuccessRate(4);
            AssemblyLine.SuccessRate(5);
            AssemblyLine.SuccessRate(6);
            AssemblyLine.SuccessRate(7);
            AssemblyLine.SuccessRate(8);
            AssemblyLine.SuccessRate(9);
            AssemblyLine.SuccessRate(10);
        }   
        static void LogAnalysis()
        {
            var log = "[INFO]: Programa corrompido com sucesso";
            var ex = "FIND >>> SOMETHING <===<";
            var x = "0123456789";
            var y = "I am the 1st test";
            var z = "I am the 2st test";
            log.SubstringAfter(": ");
            log.SubstringBetween("[", "]");
            log.Message();
            log.LogLevel();
            ex.SubstringBetween(">>> ", " <===<");
            x.SubstringBetween("234", "789");
            y.SubstringAfter("I");
            z.SubstringAfter("2st");
        }
        static void LogLineEx()
        {
            LogLine.Message("[ERROR]: Erro inválido mas dá para usar");
            LogLine.LogLevel("[ERROR]: Erro inválido mas dá para usar");
            LogLine.Reformat("[ERROR]: Erro inválido mas dá para usar");
        }
        static void QuestLogic()
        {
            var questLogic = new QuestLogic();

            Console.WriteLine(questLogic.CanFastAttack(true));
            Console.WriteLine(questLogic.CanSpy(true, false, false));
            Console.WriteLine(questLogic.CanSignalPrisoner(false, false));
            Console.WriteLine(questLogic.CanFreePrisoner(false, false, true, true));
        }
        static void TestaLasagna()
        {
            var lasagna = new Lasagna();

            Console.WriteLine(lasagna.ExpectedMinutesInOven());
            Console.WriteLine(lasagna.RemainingMinutesInOven(30));
            Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
            Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));            
        }
    }
}
