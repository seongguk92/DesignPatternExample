using System;

namespace FactoryAbstractPattern
{
    class LightList : Component
    {
        protected override string GetCompName()
        {
            return $"Light List";
        }
    }
}
