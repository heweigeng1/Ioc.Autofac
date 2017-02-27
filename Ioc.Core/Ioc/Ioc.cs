using Autofac;
using Ioc.Core.Extensions;
using Ioc.Service;
using Ioc.Service.Implementations;
using System;
using System.Reflection;

namespace Ioc.Core.Ioc
{
    public class Ioc
    {
        private static readonly ContainerBuilder _container;
        private static  IContainer _Icontainer;
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
            _Icontainer= _container.Build();
        }
        public static T Get<T>()
        {
            return _Icontainer.Resolve<T>();
        }
    }
}
