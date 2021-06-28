using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("User : User code with Service Process");
            Service service = new Service();
            user.UserCode(service);

            Console.WriteLine();

            Console.WriteLine("User : User code with Proxy Process");
            Proxy proxy = new Proxy(service);
            user.UserCode(proxy);
        }
    }
}
