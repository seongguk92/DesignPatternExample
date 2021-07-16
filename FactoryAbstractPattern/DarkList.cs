using System;

namespace FactoryAbstractPattern
{
    class DarkList : Component
    {
        protected override string GetCompName()
        {
            return $"Dark List";
        }
    }
}
