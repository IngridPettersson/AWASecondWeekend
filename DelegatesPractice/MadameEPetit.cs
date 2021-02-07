using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractice
{

    class MadameEPetit : CrewMember
    {
        public MadameEPetit(int age, bool willDoMyThing) : base("Madame E Petit", age, willDoMyThing)
        {

        }

        public override void DoYourThing()
        {
            Console.WriteLine("Saying \"Nej! Ennia!\"");
        }
    }
}
