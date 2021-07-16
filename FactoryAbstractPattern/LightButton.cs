using System;

namespace FactoryAbstractPattern
{
    class LightButton : Component
    {
        protected override string GetCompName()
        {
            return $"Light Button";
        }
    }
}
