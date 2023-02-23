using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDIIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 for debug, 0 for normal mode:");

            int mode = 0;
            Int32.TryParse(Console.ReadLine(), out mode);

            if(mode == 0)
            {
                DependencyInjector.IsDebug = false;
            }
            else
            {
                DependencyInjector.IsDebug = true;
            }

            var shuriken = DependencyInjector.Kernel.Get<IShuriken>();
            var sword = DependencyInjector.Kernel.Get<ISword>();

            var samurai = new Samurai(shuriken);
            var samurai2 = new Samurai(sword);

            samurai.Attack("the target");
            samurai2.Attack("the target");

            var sword2 = DependencyInjector.Kernel.Get<ISword>();

            Console.ReadKey();
        }
    }
}
