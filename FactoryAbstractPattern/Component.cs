using System;

namespace FactoryAbstractPattern
{
    public abstract class Component
    {
        protected abstract string GetCompName(CEnum.ELight eLight);
        public Component(CEnum.ELight eLight)
        {
            Console.WriteLine($"{this.GetCompName(eLight)} 생성");
        }
    }
}
