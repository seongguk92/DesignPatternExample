using System;

namespace FactoryMethodPattern
{
    class DropDown : Component
    {
        protected override string GetCompName()
        {
            return "DropDown";
        }
    }
}
