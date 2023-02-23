using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDIIntro
{
    public static class DependencyInjector
    {
        private static IKernel kernel;

        public static IKernel Kernel
        {
            get
            {
                if (kernel == null)
                {
                    kernel = new StandardKernel();
                    CreateBindings();
                }

                //kernel.Bind

                return kernel;
            }
        }

        public static bool IsDebug { get; set; }

        private static void CreateBindings()
        {
            Console.WriteLine($"Registering binding in debug mode: {IsDebug}");
            if (!IsDebug)
            {
                kernel.Bind<IShuriken>().To<Shuriken>();
                kernel.Bind<ISword>().To<Sword>();
            } 
            else
            {
                kernel.Bind<IShuriken>().To<DebugShuriken>();
                kernel.Bind<ISword>().To<DebugSword>();
            }
        }

        public static void UnregisterSword()
        {
            kernel.Unbind<ISword>();
        }
    }
}
