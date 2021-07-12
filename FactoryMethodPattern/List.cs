using System;

namespace FactoryMethodPattern
{
    class List : Component
    {
        protected override string GetCompName()
        {
            return "List";
        }
    }
}
