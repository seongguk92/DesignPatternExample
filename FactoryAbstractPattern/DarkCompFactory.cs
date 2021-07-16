using System;

namespace FactoryAbstractPattern
{
    class DarkCompFactory : CompFactory
    {
        public Component GetComp (CEnum.EUsage usage)
        {
            Component result;
            switch(usage)
            {
                case CEnum.EUsage.BUTTON:
                    result = new DarkButton();
                    break;
                case CEnum.EUsage.LIST:
                    result = new DarkList();
                    break;
                case CEnum.EUsage.DROPDOWN:
                    result = new DarkDropDown();
                    break;
                default:
                    result = new DarkButton();
                    break;
            }

            return result;
        }
    }
}
