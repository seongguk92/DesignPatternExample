using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class CarAccessoriesDecorator : ICar
    {
        private ICar icar;

        public CarAccessoriesDecorator(ICar _icar)
        {
            this.icar = _icar;
        }

        public virtual string GetDescription()
        {
            return this.icar.GetDescription();
        }
        public virtual double GetCost()
        {
            return this.icar.GetCost();
        }
    }
}
