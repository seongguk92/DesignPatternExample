using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class LuxuryCar : ICar
    {
        public string GetDescription()
        {
            return "Luxury Car 입니다.";
        }
        public double GetCost()
        {
            return 1414141414.1;
        }
    }
}
