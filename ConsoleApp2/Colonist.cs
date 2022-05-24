using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph
{
    internal class Colonist
    {
        private string Forename;
        private string Surname;
        private string Job;
        private int Condition;

        public Colonist(string NForename, string NSurname, string NJob)
        {
            Forename = NForename;
            Surname = NSurname;
            Job = NJob;
            Condition = 2;
        }

        public string GetForename()
        {
            return Forename;
        }

        public void SetForename(string NForename)
        {
            Forename = NForename;
        }

        public string GetSurname()
        {
            return Surname;
        }

        public void SetSurname(string NSurname)
        {
            Surname = NSurname;
        }

        public string GetJob()
        {
            return Job;
        }

        public void SetJob(string NJob)
        {
            Job = NJob;
        }

        public int GetCondition()
        {
            return Condition;
        }

        public void SetCondition(int NCondition)
        {
            Condition = NCondition;
            if (Condition < 0)
            {
                Condition = 0;
            }
        }

        public void PrintCondition()
        {
            if (GetCondition() == 0)
            {
                Console.WriteLine("{0} {1} is dead.", GetForename(), GetSurname());
            }
            else if (GetCondition() == 1)
            {
                Console.WriteLine("{0} {1} is unconscious.", GetForename(), GetSurname());
            }
            else if (GetCondition() == 2)
            {
                Console.WriteLine("{0} {1} is healthy.", GetForename(), GetSurname());
            }
            else
            {
                Console.WriteLine("{0} {1} is dissapointed in you for cheating.", GetForename(), GetSurname());
            }
        }

        public void Shoot(Object Creature)
        {
            Type ObjType = Creature.GetType();
            if (Creature.Equals(typeof(Xenomorph)))
            {
                Xenomorph XenoTarget = (Xenomorph)Creature;
                XenoTarget.Damage(1);
                Console.Write("{0} {1} has shot {2}! ");
                if (XenoTarget.GetHitPoints() == 0)
                {
                    Console.WriteLine("It has now been destroyed.");
                }
                else
                {
                    Console.WriteLine("");
                }
            }

            else if (Creature.Equals(typeof(Facehugger)))
            {
                Facehugger FaceTarget = (Facehugger)Creature;
                Random RandInt = new Random();
                int Accuracy = RandInt.Next(1, 3);
                if (Accuracy == 1)
                {
                    Console.WriteLine("{0} {1} panics and misses their shot! {2} is still alive.", Forename, Surname, FaceTarget)
                }
                else
                {
                    Console.Write("{0} {1} has shot {2}! ");
                    if (FaceTarget.GetHitPoints() == 0)
                    {
                        Console.WriteLine("It has now been destroyed.");
                    }
                    else
                    {
                        Console.WriteLine("But somehow, it remains standing!");
                    }
                }
            }

            if (ObjType.Equals(typeof(Colonist)))
            {
                Console.WriteLine("No friendly fire.");
            }

            else
            {
                Console.WriteLine("How did you even get here? Method(Shoot) invalid entry. Fix coding bug.");
            }
        }
    }
}
