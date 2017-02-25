using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc.Service.Implementations
{
    public class BaseService : IBaseService
    {
        public void _write(string msg)
        {
            Console.Write(msg);
        }
    }
}
