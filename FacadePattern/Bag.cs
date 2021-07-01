using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Bag
    {
        private readonly int maxWeight = 10;//가방 무게 10kg
        private List<string> listItem = null;
        private int nowWeight;//현재 가방 무게

        public Bag()
        {
            nowWeight = 0;
            listItem = new List<string>();
        }

      
        public void addItem(string item, int weight)
        {
            if(nowWeight + weight < maxWeight)
            {
                listItem.Add(item);
                nowWeight = nowWeight + weight;
            }
        }
    }
}
