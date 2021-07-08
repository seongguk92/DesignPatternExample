using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar _icar) : base(_icar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + "+ BasicAccessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 99999999999.9;
        }
    }
}
