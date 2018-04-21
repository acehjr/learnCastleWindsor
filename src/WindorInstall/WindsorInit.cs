using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace WindorInstall
{
    public class WindsorInit
    {
        private static WindsorContainer _container;
        public static WindsorContainer GetContainer()
        {
            if (_container == null)
            {
                _container = new WindsorContainer();
                _container.Install(
                    FromAssembly.This()
                    );
            }
            return _container;
        }

        public void CloseContex()
        {
            _container.Dispose();
        }
    } 
}
