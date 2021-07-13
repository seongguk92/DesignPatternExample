using System;

namespace FactoryAbstractPattern
{
    class Button : Component
    {
        public Button(CEnum.ELight eLight)
        {
            Console.WriteLine($"{this.GetCompName(eLight)} 생성");
        }

        protected override string GetCompName(CEnum.ELight elight)
        {
            return $"{elight} Button";
        }
    }
}
