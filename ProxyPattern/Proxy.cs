using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy : IService
    {
        private Service service1;

        public Proxy(Service service)
        {
            this.service1 = service;
        }

        public void Process()
        {
            Console.WriteLine("Proxy는 호출에 대한 흐름 제어가 주목적!");
            if (CheckIP())
            {
                this.service1.Process();
                ProxyLog(true);
            }
            else
            {
                ProxyLog(false);
            }
        }
        private bool CheckIP()
        {
            Console.WriteLine("IP CHECK");
            return true;
        }
        private void ProxyLog(bool isSuccess)
        {
            string ment = "실패";
            if(isSuccess)
            {
                ment = "성공";
            }
            Console.WriteLine($"Proxy Log / {DateTime.Now.ToString("yyyy-MM-dd tt")} / {ment}");
        }
    }
}
