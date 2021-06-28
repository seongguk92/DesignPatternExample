using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy : IService
    {
        private IService service1;
        public void Process()
        {
            Console.WriteLine("Proxy는 호출에 대한 흐름 제어가 주목적!");

            service1 = new Service();
            service1.Process();
        }
    }
}
