using System;

namespace FactoryAbstractPattern
{
    class DarkDropDown : Component
    {
        protected override string GetCompName()
        {
            return $"Dark DropDown";
        }
    }
}
