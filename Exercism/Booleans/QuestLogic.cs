using System;
using System.Collections.Generic;
using System.Text;

namespace Exercism.Booleans
{
    public class QuestLogic
    {
        public bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake == true)
            {
                Console.WriteLine("Você não pode fazer um ataque rápido, pois o arqueiro está acordado!");
                return false;
            }
            else
            {
                Console.WriteLine("Vá em frente!");
                return true;
            }
            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        }

        public bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        }

        public bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        }

        public bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent == true && archerIsAwake == false)
            {
                return true;
            }
            else if (!petDogIsPresent && prisonerIsAwake == true && knightIsAwake == false && archerIsAwake == false)
            {
                return true;
            }
            else
            {
                return false;
            }

            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
        }
    }
}
