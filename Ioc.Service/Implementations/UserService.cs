using System;

namespace Ioc.Service.Implementations
{
    public class UserService : BaseService, IUserService
    {
        public void Send(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
