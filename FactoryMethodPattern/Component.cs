﻿using System;

namespace FactoryMethodPattern
{
    public abstract class Component
    {
        protected abstract string GetCompName();
        public Component()
        {
            Console.WriteLine($"{this.GetCompName()} 생성");
        }
    }
}
