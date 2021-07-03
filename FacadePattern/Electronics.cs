using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Electronics : IItem
    {
        private Dictionary<string, int> electronics;
        public Electronics()
        {
            electronics = new Dictionary<string, int>();
            electronics.Add("핸드폰", 2);
            electronics.Add("노트북", 5);
            electronics.Add("충전기", 1);
            electronics.Add("에어팟", 2);
        }

      
        public int GetWeight(string foodName)
        {
            int result = 0;
            if (electronics.ContainsKey(foodName))
            {
                result = electronics[foodName];
            }
            else
            {
                Console.WriteLine($"{foodName}은 집에 없어요...");
            }

            return result;
        }
    }
}
