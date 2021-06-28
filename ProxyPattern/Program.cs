using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proxy를 호출하여 Process 실행
            Proxy proxy = new Proxy();
            proxy.Process();
        }
    }
}
