using System;

namespace FactoryAbstractPattern
{
    class DarkButton : Component
    {
        protected override string GetCompName()
        {
            return $"Dark Button";
        }
    }
}
