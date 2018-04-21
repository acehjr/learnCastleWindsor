using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core;
using Castle.Windsor;
using Castle.Windsor.Configuration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
namespace WindorInstall
{
    public class ChargeInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed("ChargeSpace").InNamespace("ChargeSpace").WithService.DefaultInterfaces());
        }
    }

    public class PrintInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed("PrintSpace").InNamespace("PrintSpace").WithService.DefaultInterfaces());
        }
    } 

}
