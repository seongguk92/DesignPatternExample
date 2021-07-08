using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class DeluxCar : ICar
    {
        public string GetDescription()
        {
            return "Delux Car 입니다.";
        }
        public double GetCost()
        {
            return 33333333.1;
        }
    }
}
