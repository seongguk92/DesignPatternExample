using System;

namespace FactoryAbstractPattern
{
    class LightCompFactory : CompFactory
    {
        public Component GetComp (CEnum.EUsage usage)
        {
            Component result;
            switch(usage)
            {
                case CEnum.EUsage.BUTTON:
                    result = new LightButton();
                    break;
                case CEnum.EUsage.LIST:
                    result = new LightList();
                    break;
                case CEnum.EUsage.DROPDOWN:
                    result = new LightDropDown();
                    break;
                default:
                    result = new LightButton();
                    break;
            }

            return result;
        }
    }
}
