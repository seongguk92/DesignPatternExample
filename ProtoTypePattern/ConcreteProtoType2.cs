using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTypePattern
{
    public class ConcreteProtoType2 : ProtoType
    {
        public override ProtoType Clone()
        {
            Console.WriteLine("ConcreteProtoType2 Clone");
            return (ConcreteProtoType2)this.MemberwiseClone();
        }
    }
}
