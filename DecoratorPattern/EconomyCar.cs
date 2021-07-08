using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "Economy Car 입니다.";
        }
        public double GetCost()
        {
            return 1234.5678;
        }
    }
}
