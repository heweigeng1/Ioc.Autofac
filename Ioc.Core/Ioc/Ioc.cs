using Autofac;
using System;
using System.Reflection;

namespace Ioc.Core.Ioc
{
    public class Ioc<T>
    {
        private static readonly ContainerBuilder _container;
        static Ioc()
        {
            if (_container != null)
            {
                _container = new ContainerBuilder();
            }
        }
        public static void RegisterInheritedTypes(Assembly assembly, Type baseType)
        {

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
