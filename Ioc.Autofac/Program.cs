﻿using Autofac;
using Ioc.Core.Ioc;
using Ioc.Service;
using Ioc.Service.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc.Autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<BaseService>().As<IBaseService>();
            //using (IContainer container = builder.Build())
            //{
            //    var  manager = container.Resolve<IBaseService>();
            //    manager._write("我是一个工人");  //输出我是一个工人
            //}
            Ioc<IBaseService>.RegisterInheritedTypes(typeof(IUserService).Assembly, typeof(BaseService));
            Ioc<IUserService>.Get().Send("我测试ioc");
        }
    }
}
