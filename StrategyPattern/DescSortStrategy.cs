using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DescSortStrategy : IStrategy
    {
        /// <summary>
        /// REVERSE SORT (DESC)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<int> GetSortList(List<int> data)
        {
            data.Sort();
            data.Reverse();//reverse
            return data;
        }
    }
}
