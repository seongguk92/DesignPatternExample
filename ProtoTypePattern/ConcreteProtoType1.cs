using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTypePattern
{
    public class ConcreteProtoType1 : ProtoType
    {
        public override ProtoType Clone()
        {
            Console.WriteLine("ConcreteProtoType1 Clone");
            return (ConcreteProtoType1)this.MemberwiseClone();
        }
    }
}
