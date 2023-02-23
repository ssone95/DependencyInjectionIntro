﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionIntro
{
    public class Shuriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }
    }

    public class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }
}
