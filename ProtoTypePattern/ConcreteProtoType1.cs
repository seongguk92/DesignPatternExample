using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTypePattern
{
    public class ConcreteProtoType1 : ProtoType
    {
        public override ProtoType Clone()
        {
            return (ConcreteProtoType1)this.MemberwiseClone();
        }
    }
}
