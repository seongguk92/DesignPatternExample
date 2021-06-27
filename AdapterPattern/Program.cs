using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var transport = new Adapter();
            transport.Commute();//자동차가 디폴트이므로 페달 밟기!
        }
    }
}
