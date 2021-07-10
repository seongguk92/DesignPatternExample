using System;

namespace FactoryMethodPattern
{
    class CompFactory
    {
        public Component GetComp (CEnum.Usage usage)
        {
            Component result;
            switch(usage)
            {
                case CEnum.Usage.BUTTON:
                    result = new Button();
                    break;
                case CEnum.Usage.LIST:
                    result = new List();
                    break;
                case CEnum.Usage.DROPDOWN:
                    result = new DropDown();
                    break;
                default:
                    result = new Button();
                    break;
            }

            return result;
        }
    }
}
