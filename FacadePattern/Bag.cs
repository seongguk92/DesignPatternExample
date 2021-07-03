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

      
        public void AddItem(string item, int weight)
        {
            if(nowWeight + weight < maxWeight && !weight.Equals(0))
            {
                listItem.Add(item);
                nowWeight = nowWeight + weight;
                Console.WriteLine($"가방에 {item}을 담았습니다. 현재 무게{nowWeight}/{maxWeight}");
            }
            else
            {
                Console.WriteLine($"가방이 가득 차서 {item}을 담지 못했습니다.");
            }
        }
        
        public void ViewItemList()
        {
            foreach (string item in listItem)
            {
                Console.WriteLine($"가방에 {item}이 있습니다.");
            }
        }
    }
}
