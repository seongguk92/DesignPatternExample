using System;

namespace FactoryAbstractPattern
{
    class LightDropDown : Component
    {
        protected override string GetCompName()
        {
            return $"Light DropDown";
        }
    }
}
