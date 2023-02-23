using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDIIntro
{
    public interface IWeapon
    {
        void Hit(string target);
    }

    public interface IShuriken : IWeapon { }
    public interface ISword : IWeapon { }
}
