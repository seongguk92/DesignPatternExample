using System;

namespace FactoryAbstractPattern
{
    class GreenCompFactory : CompFactory
    {
        public Component GetComp (CEnum.EUsage usage)
        {
            Component result;
            switch(usage)
            {
                case CEnum.EUsage.BUTTON:
                    result = new Button();
                    break;
                case CEnum.EUsage.LIST:
                    result = new List();
                    break;
                case CEnum.EUsage.DROPDOWN:
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
