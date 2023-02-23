using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDIIntro
{
    public class Shuriken : IShuriken
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }
    }

    public class LargeShuriken : IShuriken
    {
        public void Hit(string target)
        {
            Console.WriteLine("Large Shuriken Pierced {0}'s armor", target);
        }
    }

    public class DebugShuriken : IShuriken
    {
        public void Hit(string target)
        {
            Console.WriteLine("[Debug] Pierced {0}'s armor", target);
        }
    }

    public class Sword : ISword
    {
        public void Hit(string target)
        {
            Console.WriteLine("Sliced {0} in half", target);
        }
    }

    public class DebugSword : ISword
    {
        public void Hit(string target)
        {
            Console.WriteLine("[Debug] Sliced {0} in half", target);
        }
    }
}
