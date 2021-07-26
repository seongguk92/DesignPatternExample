using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HumanBuilder
    {
        private int money;
        private string name;
        private float height;
        private float weight;
        private bool isCar;
        private bool isJob;

        public HumanBuilder SetMoney(int money)
        {
            this.money = money;
            return this;
        }
        public HumanBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public HumanBuilder SetHeight(float height)
        {
            this.height = height;
            return this;
        }
        public HumanBuilder SetWeight(float weight)
        {
            this.weight = weight;
            return this;
        }
        public HumanBuilder SetIsCar(bool isCar)
        {
            this.isCar = isCar;
            return this;
        }
        public HumanBuilder SetIsJob(bool isJob)
        {
            this.isJob = isJob;
            return this;
        }
        public Human Build()
        {
            Human human = new Human(money, name, height, weight, isCar, isJob);
            return human;
        }
    }
}
