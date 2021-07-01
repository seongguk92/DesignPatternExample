using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Food : Item
    {
        private Dictionary<string, int> foods;
        public Food()
        {
            foods = new Dictionary<string, int>();
            foods.Add("양파", 1);
            foods.Add("초콜릿", 1);
            foods.Add("수박", 4);
            foods.Add("과자", 2);
        }

      
        public int GetWeight(string foodName)
        {
            int result = 0;
            if (foods.ContainsKey(foodName))
            {
                result = foods[foodName];
            }

            return result;
        }
    }
}
