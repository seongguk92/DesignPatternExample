using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Food : IItem
    {
        private Dictionary<string, int> food;
        public Food()
        {
            food = new Dictionary<string, int>();
            food.Add("양파", 1);
            food.Add("초콜릿", 1);
            food.Add("수박", 4);
            food.Add("과자", 2);
        }

      
        public int GetWeight(string foodName)
        {
            int result = 0;
            if (food.ContainsKey(foodName))
            {
                result = food[foodName];
            }

            return result;
        }
    }
}
