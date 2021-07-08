using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar _icar) : base(_icar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + "+ AdvancedAccessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.11111;
        }
    }
}
