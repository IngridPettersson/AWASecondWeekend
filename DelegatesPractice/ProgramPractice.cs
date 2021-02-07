using System;
using System.Collections.Generic;

namespace DelegatesPractice
{

    // I practice delegates and inheritance with virtual/override methods in this project.
    class ProgramPractice
    {
        
        static void Main(string[] args)
        {


        Mamai mamai = new Mamai(33, true);
            BabaS babaS = new BabaS(30, false);
            MadameEPetit madameEPetit = new MadameEPetit(2, true);
            CrewMember.MyCrewList.Add(mamai);
            CrewMember.MyCrewList.Add(babaS);
            CrewMember.MyCrewList.Add(madameEPetit);

            CrewMember.WillDoYourThing(CrewMember.MyCrewList, member => member.PropWillDoMyThing == true);
            
        }
    }

    delegate bool delWillDoYourThing(CrewMember crewMember);
}
