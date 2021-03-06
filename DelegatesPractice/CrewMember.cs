﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractice
{
    class CrewMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool PropWillDoMyThing { get; set; }

        public static List<CrewMember> MyCrewList = new List<CrewMember>();

        public CrewMember(string name, int age, bool paramWillDoMyThing)
        {
            Name = name;
            Age = age;
            PropWillDoMyThing = paramWillDoMyThing;
        }

        public virtual void DoYourThing()
        {

        }

        public static void WillDoYourThing(List<CrewMember> crewMembers, delWillDoYourThing delArgWillDoYourThing)
        {
            foreach (CrewMember crewMember in crewMembers)
            {
                if (delArgWillDoYourThing(crewMember))
                    crewMember.DoYourThing();
                else
                    Console.WriteLine($"{crewMember.Name} is not in the mood...");

            }

        }
    }
}
