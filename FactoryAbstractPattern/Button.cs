using System;

namespace FactoryAbstractPattern
{
    class Button : Component
    {
        protected override string GetCompName(CEnum.ELight elight)
        {
            return $"{elight} Button";
        }
    }
}
