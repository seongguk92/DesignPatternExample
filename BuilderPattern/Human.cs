using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Human
    {
        private int money;
        private string name;
        private float height;
        private float weight;
        private bool isCar;
        private bool isJob;

        public Human(int money, string name, float height, float weight, bool isCar, bool isJob)
        {
            this.money = money;
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.isCar = isCar;
            this.isJob = isJob;
        }

        public void WriteHumanInfo()
        {
            Console.WriteLine($"{this.money}/{this.name}/{this.height}/{this.weight}/{this.isCar}/{this.isJob}");
        }
    }
}
