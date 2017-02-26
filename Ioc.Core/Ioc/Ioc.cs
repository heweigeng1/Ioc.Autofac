using Autofac;
using Ioc.Core.Extensions;
using Ioc.Service;
using Ioc.Service.Implementations;
using System;
using System.Reflection;

namespace Ioc.Core.Ioc
{
    public class Ioc<T>
    {
        private static readonly ContainerBuilder _container;
        static Ioc()
        {
            if (_container == null)
            {
                _container = new ContainerBuilder();
            }
        }
        public static void RegisterInheritedTypes(Assembly assembly, Type baseType)
        {
            _container.RegisterInheritedTypes(assembly, baseType);
        }
        public static T Get()
        {
            
            using (IContainer _Icontainer=_container.Build())
            {
                return _Icontainer.Resolve<T>();
            }
        }
    }
}
