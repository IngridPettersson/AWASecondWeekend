﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractice
{
    class Mamai : CrewMember
    {
        public Mamai(int age, bool willDoMyThing) : base("Mamai", age, willDoMyThing)
        {

        }

        public override void DoYourThing()
        {
            Console.WriteLine($"{Name} doing her thing: Dancing happily ever after...");
        }
    }
}
