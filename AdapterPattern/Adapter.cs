using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adapter : ITransport
    {
        private Car _car => new Car();
        public void Commute()
        {
            _car.GasPedal();
        }
    }
}
