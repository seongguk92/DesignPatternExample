using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class User
    {
        public void UserCode(IService service)
        {
            //A 작업
            service.Process();
            //B 작업
        }
    }
}
