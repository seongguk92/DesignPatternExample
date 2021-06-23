using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IStrategy
    {
        List<int> GetSortList(List<int> data);
    }
}
