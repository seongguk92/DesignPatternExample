using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class AscSortStrategy : IStrategy
    {
        /// <summary>
        /// 기본 SORT (ASC)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<int> GetSortList(List<int> data)
        {
            data.Sort();//sort
            return data;
        }
    }
}
