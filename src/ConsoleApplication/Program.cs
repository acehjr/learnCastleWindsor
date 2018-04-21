using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.MicroKernel;
using WindorInstall;
using iInterface;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = WindsorInit.GetContainer();
            ICharge charge = container.Resolve<ICharge>();
            charge.ClinicChcarge();
            Console.ReadKey();
        }

        //public void test(ICharge charge)
        //{
        //    charge.ClinicChcarge();
        //    Console.ReadKey();
        //}
    }
}
