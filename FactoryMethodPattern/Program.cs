using System;

namespace FactoryMethodPattern
{
    class Program
    {
        private static CompFactory compFactory = new CompFactory();

        static Component comp1;
        static Component comp2;
        static Component comp3;

        /// <summary>
        /// 일반 생성
        /// </summary>
        private static void WithOutFactory()
        {
            comp1 = new Button();
            comp2 = new List();
            comp3 = new DropDown();
        }

        /// <summary>
        /// 팩토리 이용 생성
        /// </summary>
        private static void WithFactory()
        {
            comp1 = compFactory.GetComp(CEnum.Usage.BUTTON);
            comp2 = compFactory.GetComp(CEnum.Usage.LIST);
            comp3 = compFactory.GetComp(CEnum.Usage.DROPDOWN);
        }

        static void Main(string[] args)
        {
            WithOutFactory();
            WithFactory();
        }
    }
}
