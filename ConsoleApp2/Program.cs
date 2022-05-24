using System;

namespace Xenomorph
{
    class Program
    {
        // Used to verify that the colonist class works/
        public static void TestColonist()
        {
            Colonist Jeremy = new Colonist("Jeremy", "Jone", "Medic");
            Colonist Fitz = new Colonist("Fitz", "Jerald", "Scavenger");
            Colonist Max = new Colonist("Max", "Miths", "Metalworker");
            Colonist Amy = new Colonist("Amy", "Hanes", "Fighter");

            Console.WriteLine(Max.GetForename());
            Max.SetForename("Jake");
            Console.WriteLine(Max.GetForename());

            Console.WriteLine(Fitz.GetSurname());
            Fitz.SetSurname("Josiah");
            Console.WriteLine(Fitz.GetSurname());

            Console.WriteLine(Max.GetJob());
            Max.SetJob("Hotel Owner");
            Console.WriteLine(Max.GetJob());

            Console.WriteLine(Amy.GetCondition());
            Amy.PrintCondition();
            Amy.SetCondition(1);
            Console.WriteLine(Amy.GetCondition());
            Amy.PrintCondition();
            Amy.SetCondition(0);
            Console.WriteLine(Amy.GetCondition());
            Amy.PrintCondition();
            Amy.SetCondition(3);
            Console.WriteLine(Amy.GetCondition());
            Amy.PrintCondition();

            Amy.Shoot(Fitz);
        }

        public static void TestFacehugger()
        {
            Facehugger Face1 = new Facehugger(1);
            Facehugger Face2 = new Facehugger(2);
            Facehugger Face3 = new Facehugger(3);
            Facehugger Face4 = new Facehugger(4);
            Colonist Jake = new Colonist("Jake", "Jack", "Tester");

            Console.WriteLine(Face1.GetName());
            Face1.SetName("FaceHugger");
            Console.WriteLine(Face1.GetName());

            Console.WriteLine(Face1.GetHitPoints());
            Face1.Damage(3);
            Console.WriteLine(Face1.GetHitPoints());

            Console.WriteLine(Face4.GetNumber());

            Face1.Hug(Jake);
            Jake.PrintCondition();
            Face2.Hug(Face1);
            Face1.Hug(Jake);
        }
        // LESSON LEARNED HERE! Even if you transfer an object to a different variable, such as changing Jack to the CTarget variable in the Hug method (Facehugger), they are all linked! Changing a value in 1 will change all instances of that exact object. In this case, Jack becomes unconscious.
        public static void Main(string[] args)
        {
            TestFacehugger();
        }
    }
}