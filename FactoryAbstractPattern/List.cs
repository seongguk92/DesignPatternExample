using System;

namespace FactoryAbstractPattern
{
    class List : Component
    {
        protected override string GetCompName(CEnum.ELight elight)
        {
            return $"{elight} List";
        }
    }
}
