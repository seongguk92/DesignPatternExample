using System;

namespace FactoryAbstractPattern
{
    class Program
    {
        private static CompFactory lightCompFactory = new LightCompFactory();
        private static CompFactory DarkCompFactory = new DarkCompFactory();

        private static Component comp1;
        private static Component comp2;
        private static Component comp3;

        static void Main(string[] args)
        {
            comp1 = lightCompFactory.GetComp(CEnum.EUsage.BUTTON);
            comp2 = lightCompFactory.GetComp(CEnum.EUsage.DROPDOWN);
            comp3 = lightCompFactory.GetComp(CEnum.EUsage.LIST);

            comp1 = DarkCompFactory.GetComp(CEnum.EUsage.BUTTON);
            comp2 = DarkCompFactory.GetComp(CEnum.EUsage.DROPDOWN);
            comp3 = DarkCompFactory.GetComp(CEnum.EUsage.LIST);
        }
    }
}
