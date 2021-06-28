using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Service : IService
    {
        public void Process()
        {
            Console.WriteLine("Process 동작");
        }
    }
}
