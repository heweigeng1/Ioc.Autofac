using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ioc.Core.Extensions
{
    public static class AutofacExtensions
    {
        //
        public static void RegisterInheritedTypes(this ContainerBuilder container, Assembly assembly, Type baseType)
        {
            var allTypes = assembly.GetTypes();
            var baseInterfaces = baseType.GetInterfaces();//获取类型接口
            container.RegisterType(baseType).AsImplementedInterfaces();
            foreach (var type in allTypes)
            {
                if (type.BaseType != null && type.BaseType.GenericEq(baseType))
                {
                    var typeInterface = type.GetInterfaces().FirstOrDefault(x => !baseInterfaces.Any(bi => bi.GenericEq(x)));
                    if (typeInterface == null)
                    {
                        continue;
                    }
                    container.RegisterType(type).As(typeInterface);
                }
            }
        }
    }
}
