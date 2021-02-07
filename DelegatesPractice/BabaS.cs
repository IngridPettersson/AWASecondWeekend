using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractice
{
    class BabaS : CrewMember
    {
        public BabaS(int age, bool willDoMyThing) : base("Baba S", age, willDoMyThing)
        {

        }

        public override void DoYourThing()
        {
            Console.WriteLine("Playing the guitar...");
        }
    }
}
