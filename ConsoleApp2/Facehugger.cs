using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph
{
    internal class Facehugger
    {
        private string Name;
        private bool HasEmbryo;
        private int Number;
        private int HitPoints;

        public Facehugger(int NewNumber)
        {
            Name = "Facehugger";
            HasEmbryo = true;
            Number = NewNumber;
            HitPoints = 1;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string NewName)
        {
            Name = NewName;
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

        public int GetNumber()
        {
            return Number;
        }

        public void Hug(Object Target)
        {
            Type TargetType = Target.GetType();
            if (TargetType.Equals(typeof(Colonist)))
            {
                if (HasEmbryo == false)
                {
                    Console.WriteLine("The Facehugger has no embryo");
                }
                else
                {
                    Colonist CTarget = (Colonist)Target;
                    HasEmbryo = false;
                    CTarget.SetCondition(1);
                    Console.WriteLine("The Facehugger has now attatched itself to {0} {1}. They are now unconscious.", CTarget.GetForename(), CTarget.GetSurname());
                }
            }
            else
            {
                Console.WriteLine("The Facehugger sees no point in harming it's brethren");
            }
        }
    }
}
