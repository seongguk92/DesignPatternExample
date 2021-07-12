using System;

namespace FactoryAbstractPattern
{
    class DropDown : Component
    {
        protected override string GetCompName(CEnum.ELight elight)
        {
            return $"{elight} DropDown";
        }
    }
}
