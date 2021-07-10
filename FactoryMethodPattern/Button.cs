using System;

namespace FactoryMethodPattern
{
    class Button : Component
    {
        protected override string GetCompName()
        {
            return "Button";
        }
    }
}
