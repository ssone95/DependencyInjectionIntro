using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionIntro
{
    public class Samurai
    {
        private readonly IWeapon weapon;
        public Samurai(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
