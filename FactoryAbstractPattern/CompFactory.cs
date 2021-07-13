using System;

namespace FactoryAbstractPattern
{
    interface CompFactory
    {
        public Component GetComp(CEnum.EUsage usage);
    }
}
