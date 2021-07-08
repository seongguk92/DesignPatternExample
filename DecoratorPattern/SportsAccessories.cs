using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar _icar) : base(_icar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + "+ SportsAccessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 333.3333333333;
        }
    }
}
