using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph
{
    internal class Xenomorph
    {
        private string Name;
        private int KillCount;
        private int HitPoints;

        public Xenomorph()
        {
            Name = "Kane's son";
            KillCount = 0;
            HitPoints = 3;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string NewName)
        {
            Name = NewName;
        }

        public int GetKillCount()
        {
            return KillCount;
        }

        public int GetHitPoints()
        {
            return HitPoints;
        }

        public void Damage(int DmgTaken)
        {
            HitPoints = HitPoints - DmgTaken;
            if (HitPoints < 0)
            {
                HitPoints = 0;
            }
        }

        public void Kill(Object Target)
        {
            Type TargetType = Target.GetType();
            if (TargetType.Equals(typeof(Colonist)))
            {
                Colonist CTarget = (Colonist)Target;
                if (CTarget.GetCondition() >= 2)
                {
                    CTarget.SetCondition(0);
                    KillCount++;
                    Console.WriteLine("{0} has attacked and slain {1} {2}. {0} has now killed {3} colonists", Name, CTarget.GetForename(), CTarget.GetSurname(), KillCount);
                }
                else if (CTarget.GetCondition() == 1)
                {
                    Console.WriteLine("{0} refuses to attack the unconscious {1} {2}", Name, CTarget.GetForename(), CTarget.GetSurname());
                }
                else
                {
                    Console.WriteLine("{0} finds no interest in the dead.", Name);
                }
            }
            else
            {
                Console.WriteLine("The Xenomorph sees no point in harming it's bretheren");
            }
        }
    }
}
