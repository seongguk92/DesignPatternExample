using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Context
    {
        private IStrategy _strategy;

        public IStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public Context()
        {

        }

        /// <summary>
        /// Strategy 개체에 위임
        /// </summary>
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Int Data Sort");
            var result = this._strategy.GetSortList(new List<int> { 5, 1, 2, 36, -5 });

            StringBuilder sb = new StringBuilder();
            foreach (int element in result)
            {
                sb.AppendLine(element.ToString().Trim());
            }

            Console.WriteLine(sb);
        }
    }
}
